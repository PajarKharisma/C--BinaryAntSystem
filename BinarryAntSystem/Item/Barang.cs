using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarryAntSystem.Item
{
    public class Barang : IComparable<Barang>
    {
        public String namaBarang;
        public double beratBarang;
        public double profitBarang;

        public Barang(String namaBarang, double beratBarang, double profitBarang)
        {
            this.namaBarang = namaBarang;
            this.beratBarang = beratBarang;
            this.profitBarang = profitBarang;
        }

        public int CompareTo(Barang x)
        {
            return (x.profitBarang / x.beratBarang).CompareTo(profitBarang / beratBarang);
        }
    }
}
