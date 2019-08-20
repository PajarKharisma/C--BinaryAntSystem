using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data.OleDb;
using BinarryAntSystem.Item;

namespace BinarryAntSystem
{
    public partial class Form1 : Form
    {
        public List<StringBuilder> sbList;
        List<int> indexSrb;
        List<int> indexRestart;
        int indexSgb;

        public Form1()
        {
            InitializeComponent();
            sbList = new List<StringBuilder>();
            indexSrb = new List<int>();
            indexRestart = new List<int>();
            indexSgb = 0;
        }

        void headerTas()
        {
            tasGridView.Columns[0].HeaderText = "Knapsack";
            tasGridView.Columns[1].HeaderText = "Kapasitas";
        }
        void headerBarang()
        {
            barangGridView.Columns[0].HeaderText = "Barang";
            barangGridView.Columns[1].HeaderText = "Profit";
            barangGridView.Columns[2].HeaderText = "Bobot";
        }

        private void getXls(DataGridView dataGridView, int sheet, String fileName)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[sheet];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            dataGridView.ColumnCount = colCount;
            dataGridView.RowCount = rowCount - 1;

            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        dataGridView.Rows[i - 2].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();
                    }
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        public void tampilkanHasil(Iterasi iterasi, int it)
        {
            hasilGridView.Rows.Add("Iterasi" +(it + 1), iterasi.sib.totalBeratSemut, iterasi.sib.totalProfitSemut, iterasi.cf, false, false, false);
        }

        public void updateCheck()
        {
            int jumlahRow = hasilGridView.Rows.Count;
            for (int i = 0; i < jumlahRow; i++)
            {
                hasilGridView[4, i].Value = indexRestart.Contains(i);
                hasilGridView[5, i].Value = indexSrb.Contains(i);
                hasilGridView[6, i].Value = (i == indexSgb);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Excel File Dialog";
            fdlg.InitialDirectory = @"input";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
                txtInput.Text = fname;
            }

            getXls(tasGridView, 1, fname);
            headerTas();

            getXls(barangGridView, 2, fname);
            headerBarang();
        }

        private void ProsesButton_Click(object sender, EventArgs e)
        {
            hasilGridView.ColumnCount = 7;
            hasilGridView.Columns[0].HeaderText = "Iterasi";
            hasilGridView.Columns[1].HeaderText = "Berat";
            hasilGridView.Columns[2].HeaderText = "Profit";
            hasilGridView.Columns[3].HeaderText = "Cf";
            hasilGridView.Columns[4].HeaderText = "Restart";
            hasilGridView.Columns[5].HeaderText = "srb";
            hasilGridView.Columns[6].HeaderText = "sgb";
            //hasilGridView.RowCount = 100;

            int jumlahBarang = barangGridView.RowCount - 1;
            Barang[] barangArray = new Barang[jumlahBarang];
            for (int i = 0; i < barangArray.Length; i++)
            {
                barangArray[i] = new Barang(Convert.ToString(barangGridView[0, i].Value), Convert.ToDouble(barangGridView[1, i].Value), Convert.ToDouble(barangGridView[2, i].Value));
            }
            int jumlahTas = tasGridView.RowCount - 1;
            Tas[] tasArray = new Tas[jumlahTas];
            for (int i = 0; i < jumlahTas; i++)
            {
                tasArray[i] = new Tas(Convert.ToString(tasGridView[0, i].Value), Convert.ToDouble(tasGridView[1, i].Value), jumlahBarang);
            }
            Array.Sort(barangArray);
            int jumlahSemut = Int32.Parse(jumlahSemutInput.Text);
            double[,] pheromone = new double[jumlahTas, jumlahBarang];
            for (int i = 0; i < jumlahTas; i++)
            {
                for (int j = 0; j < jumlahBarang; j++)
                {
                    pheromone[i, j] = 0.5;
                }
            }
            int jumlahIterasi = Int32.Parse(jumlahIterasiInput.Text);
            double evaporasi = Double.Parse(evaporasiInput.Text);
            bool restartPheromone = true;
            Iterasi[] iterasi = new Iterasi[jumlahIterasi];

            for (int it = 0; it < iterasi.Length; it++)
            {
                iterasi[it] = new Iterasi(pheromone, evaporasi);
                Semut[] semutArray = new Semut[jumlahSemut];
                Random random = new Random();
                for (int i = 0; i < semutArray.Length; i++)
                {
                    Tas[] tasArray1 = new Tas[jumlahTas];
                    for (int j = 0; j < jumlahTas; j++)
                    {
                        tasArray1[j] = new Tas(tasArray[j].namaTas, tasArray[j].kapasitasTas, jumlahBarang);
                    }
                    semutArray[i] = new Semut(tasArray1, barangArray, random);
                }

                for (int i = 0; i < semutArray.Length; i++)
                {
                    semutArray[i].randomSolusiAwal(pheromone);
                }

                double profitMax = 0, tempMax;
                int semutMax = 0;
                for (int i = 0; i < semutArray.Length; i++)
                {
                    tempMax = semutArray[i].repairOperator();
                    if (tempMax > profitMax)
                    {
                        profitMax = tempMax;
                        semutMax = i;
                    }
                }

                iterasi[it].sib = semutArray[semutMax];
                if (it == 0)
                    iterasi[it].sgb = semutArray[semutMax];
                else
                {
                    if (semutArray[semutMax].totalProfitSemut >= iterasi[it - 1].sgb.totalProfitSemut)
                    {
                        iterasi[it].sgb = semutArray[semutMax];
                        indexSgb = it;
                    }
                    else
                    {
                        iterasi[it].sgb = iterasi[it - 1].sgb;
                    }
                }
                if (restartPheromone)
                {
                    iterasi[it].srb = semutArray[semutMax];
                    indexRestart.Add(it);
                    indexSrb.Add(it);
                    restartPheromone = false;
                    pheromone = iterasi[it].hitungPheromoneUpdate(restartPheromone);
                }
                else
                {
                    if (semutArray[semutMax].totalProfitSemut >= iterasi[it-1].srb.totalProfitSemut)
                    {
                        iterasi[it].srb = semutArray[semutMax];
                        indexSrb[indexSrb.Count - 1] = it;
                    }
                    else
                    {
                        iterasi[it].srb = iterasi[it - 1].srb;
                    }
                    double cf = iterasi[it].hitungCf();
                    if (cf >= 0.8)
                        restartPheromone = true;
                    pheromone = iterasi[it].hitungPheromoneUpdate(restartPheromone);
                }
                tampilkanHasil(iterasi[it], it);
                //detailIterasi(semutArray, it, semutMax, iterasi[it]);
            }
            updateCheck();
        }
    }
}
