using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Dortgen : ISekil
    {
        private double tabanUzunlugu;
        private double yukseklik;

        public Dortgen(double tabanUzunlugu, double yukseklik)
        {
            this.tabanUzunlugu = tabanUzunlugu;
            this.yukseklik = yukseklik;
        }
        public double AlanHesabi()
        {
            return tabanUzunlugu * yukseklik;
        }

        public double CevreHesabi()
        {
            return (yukseklik + tabanUzunlugu) * 2;
        }
    }
}
