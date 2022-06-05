using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Ucgen");
            comboBox1.Items.Add("Dortgen");
            comboBox1.SelectedIndex = 0;
            sonuc.Text = "";
            cevreSonucu.Text = "";
            button1.Text = "Hesapla";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc.Text = "";
            cevreSonucu.Text = "";
            ISekil sekil1;
            double taban = (double)numericUpDown1.Value;
            double yukseklik = (double)numericUpDown2.Value;

            if (comboBox1.SelectedIndex == 0)
            {
                sekil1 = new Ucgen(taban, yukseklik);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sekil1 = new Dortgen(taban, yukseklik);
            }
            else
                throw new NotSupportedException(); 
            if(comboBox1.SelectedIndex == 1)
                cevreSonucu.Text = "Cevre " + sekil1.CevreHesabi().ToString() + " bulunmustur.";
            sonuc.Text = "Alan " + sekil1.AlanHesabi().ToString() + " bulunmustur.";
            
        }
    }
}
