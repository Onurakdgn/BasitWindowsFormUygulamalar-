using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int enbuyuk = 0;
            if (sayi1 > sayi2 & sayi1 > sayi3) enbuyuk = sayi1;
            else if (sayi2 > sayi3 & sayi2 > sayi1) enbuyuk = sayi2;
            else if (sayi3 > sayi2 & sayi3 > sayi1) enbuyuk = sayi3;
            else MessageBox.Show("Yanlış");
            MessageBox.Show("En büyük sayı=" + enbuyuk);
        }
    }
}
