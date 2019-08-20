using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarryAntSystem.Item
{
    public class Semut
    {
        public Barang[] barangSemut;
        public Tas[] tasSemut;
        public Random random;
        public double totalProfitSemut;
        public double totalBeratSemut;

        public Semut(Tas[] tasSemut, Barang[] barangSemut, Random random)
        {
            this.barangSemut = barangSemut;
            this.tasSemut = tasSemut;
            this.random = random;
            this.totalProfitSemut = 0;
            this.totalBeratSemut = 0;
        }

        public void randomSolusiAwal (double[,] pheromone)
		{
			bool[] sudahDiisi = new bool[pheromone.GetLength(1)];
			for (int i = 0; i<sudahDiisi.Length; i++)
				sudahDiisi[i] = false;

			for (int i = 0; i<pheromone.GetLength (0); i++)
			{
				for (int j = 0; j<pheromone.GetLength (1); j++)
				{
					if(!sudahDiisi[j])
					{
						double randomProbabilitas = random.NextDouble();
						if (randomProbabilitas <= pheromone[i, j])
						{
							tasSemut[i].isiTasAwal[j] = 1;
							sudahDiisi[j] = true;
						}
						else
						{
							tasSemut[i].isiTasAwal[j] = 0;
							sudahDiisi[j] = false;
						}
					}
					else
					{
						tasSemut[i].isiTasAwal[j] = 0;
					}
				}
			}
		}

        public double repairOperator()
        {
            bool[] sudahDiisi = new bool[tasSemut[0].isiTasAwal.Length];
            for (int i = 0; i < sudahDiisi.Length; i++)
                sudahDiisi[i] = false;
            for (int i = 0; i < tasSemut.Length; i++)
            {
                List<int> index1 = new List<int>(), index0 = new List<int>();
                for (int j = 0; j < tasSemut[i].isiTasAwal.Length; j++)
                {
                    if (tasSemut[i].isiTasAwal[j] == 1)
                    {
                        if (sudahDiisi[j])
                        {
                            tasSemut[i].isiTasAkhir[j] = 0;
                            index0.Add(j);
                        }
                        else
                        {
                            tasSemut[i].isiTasAkhir[j] = 1;
                            tasSemut[i].totalBeratTas += barangSemut[j].beratBarang;
                            index1.Add(j);
                        }
                    }
                    else
                    {
                        tasSemut[i].isiTasAkhir[j] = 0;
                        index0.Add(j);
                    }
                }
                int k = index1.Count - 1;
                while (tasSemut[i].totalBeratTas > tasSemut[i].kapasitasTas && k >= 0)
                {
                    int index = index1[k];
                    tasSemut[i].isiTasAkhir[index] = 0;
                    tasSemut[i].totalBeratTas -= barangSemut[index].beratBarang;
                    k--;
                }
                for (int l = 0; l < index0.Count; l++)
                {
                    int index = index0[l];
                    if (!sudahDiisi[index] && tasSemut[i].totalBeratTas + barangSemut[index].beratBarang <= tasSemut[i].kapasitasTas)
                    {
                        tasSemut[i].isiTasAkhir[index] = 1;
                        sudahDiisi[index] = true;
                        tasSemut[i].totalBeratTas += barangSemut[index].beratBarang;
                        tasSemut[i].totalProfitTas += barangSemut[index].profitBarang;
                    }
                }
                for (int m = k; m >= 0; m--)
                {
                    sudahDiisi[index1[m]] = true;
                    tasSemut[i].totalProfitTas += barangSemut[index1[m]].profitBarang;
                }
                totalBeratSemut += tasSemut[i].totalBeratTas;
                totalProfitSemut += tasSemut[i].totalProfitTas;
            }
            return totalProfitSemut;
        }
    }
}
