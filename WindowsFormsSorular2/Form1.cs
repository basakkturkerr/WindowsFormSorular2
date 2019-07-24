using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSorular2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 1) Ekrana bir tane datepicker elementi ve buton koy. 
        //Tarih seçip butona bastıktan sonra burcunu ekrana yazsın (Burçlara örnek yay, kova vb. Yükselene gerek yok)

        int gun;
        int ay;

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            ay = Convert.ToInt32(dtpTarih.Value.Month);
            gun = Convert.ToInt32(dtpTarih.Value.Day);
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
            {
                MessageBox.Show("BURCUNUZ KOÇ");
            }

            if ((ay == 4 & gun >= 21) || (ay == 5 & gun <= 21))
            {
                MessageBox.Show("BURCUNUZ BOĞA");
            }

            if ((ay == 5 & gun >= 22) || (ay == 6 & gun <= 21))
            {
                MessageBox.Show("BURCUNUZ İKİZLER");
            }

            if ((ay == 6 & gun >= 22) || (ay == 7 & gun <= 23))
            {
                MessageBox.Show("BURCUNUZ YENGEÇ");
            }

            if ((ay == 7 & gun >= 24) || (ay == 8 & gun <= 23))
            {
                MessageBox.Show("BURCUNUZ ASLAN");
            }

            if ((ay == 8 & gun >= 24) || (ay == 9 & gun <= 23))
            {
                MessageBox.Show("BURCUNUZ BAŞAK");
            }

            if ((ay == 9 & gun >= 22) || (ay == 10 & gun <= 23))
            {
                MessageBox.Show("BURCUNUZ TERAZİ");
            }

            if ((ay == 102 & gun >= 23) || (ay == 11 & gun <= 22))
            {
                MessageBox.Show("BURCUNUZ AKREP");
            }

            if ((ay == 11 & gun >= 23) || (ay == 12 & gun <= 22))
            {
                MessageBox.Show("BURCUNUZ YAY");
            }


        }
    }
}