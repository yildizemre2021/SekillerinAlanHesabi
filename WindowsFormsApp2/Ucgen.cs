using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Ucgen : ISekil
    {
        private double tabanUzunlugu;
        private double yukseklik;

        public Ucgen(double tabanUzunlugu, double yukseklik)
        {
            this.tabanUzunlugu = tabanUzunlugu;
            this.yukseklik = yukseklik;
        }

        public double AlanHesabi()
        {
            return tabanUzunlugu * yukseklik / 2;
        }

        public double CevreHesabi()
        {
            throw new NotImplementedException();
        }
    }
}
