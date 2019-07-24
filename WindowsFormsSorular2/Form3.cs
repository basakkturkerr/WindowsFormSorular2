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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // 3) Form2 de oluşturduğun ekrana bir tane çıkar butonu koy.Butona tıkladığında seçilen diziyi ekrandan çıkarsın.

        string[] dizilerdizi = { "GameOfThrones", "WalkingDead", "LaCaseDePapel", "StrangerThings", "BreakingBad", "Vikings" };

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dizilerdizi.Length; i++)
            {
                listBox1.Items.Add(dizilerdizi[i]);
            }
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dizilerdizi.Length; i++)
            {
                listBox1.Items.Remove(dizilerdizi[i]);
            }
        }
    }
}
