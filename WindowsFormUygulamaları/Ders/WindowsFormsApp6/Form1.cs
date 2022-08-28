using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int adet = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            double sayi = rastgele.NextDouble()*10;
            textBox1.Text = textBox1.Text + sayi+ "\r\n";
            adet++;
            if (adet>=20)
            {
                DialogResult secim = MessageBox.Show("10 Ye Ulaştınız Devam etmek istiyormusunuz ?","Seçiniz",MessageBoxButtons.YesNo);
                if (secim== DialogResult.Yes)
                {
                    textBox1.Clear();
                    adet = 0;
                }
                else
                {
                    Application.Exit();
                }

            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
