using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = Int16.Parse(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Sayısal Bir Değer Girin", "Uyarı", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0, sayi = 0;
            sayi = listBox1.Items.Count;
            for (int i = 0; i <= sayi - 1; i++)
            {
                toplam = toplam + Convert.ToInt16(listBox1.Items[i]);
            }
            label4.Text = "Listedeki Sayıların Ortalaması : " + Convert.ToString(toplam / sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox1.Items[i]);
            }
            label3.Text = "Listedeki Sayıların Toplamı : " + toplam;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
