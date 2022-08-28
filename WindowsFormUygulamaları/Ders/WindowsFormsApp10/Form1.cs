using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int faktöriyel = 1;
            for (int i = sayi; i > 1; i--)
            {
                if (i == 2)
                {
                    label2.Text += i.ToString() ;
                }
                else
                label2.Text += i.ToString() + "x";
                faktöriyel = faktöriyel * i;

            }
            label2.Text += "=" +faktöriyel;
            //Aşşağıdaki Form Görüntüsünü Oluşturunuz Ve listbox daki sayıların toplamı ve ortalamsını ilgili label lara yazdıran kodu yazınız (Butona Basınca)
        }
    }
}
