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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 2)  Ekrana bir listbox bir de buton koy. Butona tıkladığında string dizideki elemanları listbox a eklesin. 
        // (string dizi en az 5 elemanlı olacak. (string[] netflixdizi = new string[5])


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string[] dizilerdizi = { "GameOfThrones", "WalkingDead", "LaCaseDePapel", "StrangerThings", "BreakingBad", "Vikings" };

            for (int i = 0; i < dizilerdizi.Length; i++)
            {
                listbox1.Items.Add(dizilerdizi[i]);
            }
           

        }
    }
}
