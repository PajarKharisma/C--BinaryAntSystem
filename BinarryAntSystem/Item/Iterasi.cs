using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarryAntSystem.Item
{
    public class Iterasi
    {
        public double[,] pheromone;
        public double[,] pheromoneUpdate;
        public double evaporasi;
        public double cf;
        public double kib, krb, kgb;
        public double[,] m;
        public Semut sib;
        public Semut srb;
        public Semut sgb;

        public Iterasi(double[,] pheromone, double evaporasi)
        {
            this.pheromone = pheromone;
            this.evaporasi = evaporasi;
            this.kib = 0;
            this.krb = 0;
            this.kgb = 0;
        }

        public double hitungCf()
        {
            double totalPheromone = 0;
            for (int i = 0; i < pheromone.GetLength(0); i++)
            {
                for (int j = 0; j < pheromone.GetLength(1); j++)
                {
                    totalPheromone = Math.Abs(2 * pheromone[i, j] - 1);
                }
            }

            cf = totalPheromone / (pheromone.GetLength(0) * pheromone.GetLength(1));
            return cf;
        }

        public double[,] hitungPheromoneUpdate(bool restartPheromone)
        {
            if (cf < 0.2)
            {
                kib = 1;
                krb = 0;
                kgb = 0;
            }
            else if (cf >= 0.2 && cf < 0.4)
            {
                kib = 2 / 3;
                krb = 1 / 3;
                kgb = 0;
            }
            else if (cf >= 0.4 && cf < 0.6)
            {
                kib = 1 / 3;
                krb = 2 / 3;
                kgb = 0;
            }
            else if (cf >= 0.6 && cf < 0.8)
            {
                kib = 0;
                krb = 1;
                kgb = 0;
            }
            else if(cf >= 0.8)
            {
                kib = 0;
                krb = 0;
                kgb = 1;
            }

            int jumlahTas = sib.tasSemut.Length;
            int jumlahBarang = sib.barangSemut.Length;
            pheromoneUpdate = new double[jumlahTas, jumlahBarang];
            for (int i = 0; i < jumlahTas; i++)
            {
                for (int j = 0; j < jumlahBarang; j++)
                {
                    if (!restartPheromone)
                        pheromoneUpdate[i, j] = pheromone[i, j] + evaporasi * 
                            ((kib * sib.tasSemut[i].isiTasAkhir[j]
                            + krb * srb.tasSemut[i].isiTasAkhir[j]
                            + kgb * sgb.tasSemut[i].isiTasAkhir[j])
                            - pheromone[i, j]);
                    else
                        pheromoneUpdate[i, j] = 0.5;
                }
            }
			return pheromoneUpdate; 
		}
    }
}
