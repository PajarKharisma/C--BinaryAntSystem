using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarryAntSystem.Item
{
    public class Tas
    {
        public String namaTas;
        public double kapasitasTas;
        public double[] isiTasAwal;
        public double[] isiTasAkhir;
        public double totalBeratTas;
        public double totalProfitTas;

        public Tas(String namaTas, double kapasitasTas, int jumlahBarangTas)
        {
            this.namaTas = namaTas;
            this.kapasitasTas = kapasitasTas;
            this.isiTasAwal = new double[jumlahBarangTas];
            this.isiTasAkhir = new double[jumlahBarangTas];
            this.totalBeratTas = 0;
            this.totalProfitTas = 0;
        }
    }
}
