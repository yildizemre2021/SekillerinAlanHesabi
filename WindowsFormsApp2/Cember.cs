using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Cember : ISekil
    {
        private double yaricap;

        public Cember(double yaricap)
        {
            this.yaricap = yaricap;
        }

        public double AlanHesabi()
        {
            return Math.PI * yaricap * yaricap;
        }

        public double CevreHesabi()
        {
            return Math.PI * yaricap * 2;
        }
    }
}
