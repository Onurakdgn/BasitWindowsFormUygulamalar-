using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbislemsec.Items.Add("Toplama");
            cbislemsec.Items.Add("Çıkarma");
            cbislemsec.Items.Add("Çarpma");
            cbislemsec.Items.Add("Bölme");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc;
            double s1 = Convert.ToDouble(txts1.Text);
            double s2 = Convert.ToDouble(txts2.Text);
            if (cbislemsec.SelectedIndex == 0)
            {
                sonuc = s1 + s2;
            }
            else if (cbislemsec.SelectedIndex == 1)
            {
                sonuc = s1 - s2;
            }
            else if (cbislemsec.SelectedIndex == 2)
            {
                sonuc = s1 * s2;
            }
            else
            {
                sonuc = s1 / s2;
            }

            lblsonuc.Text = sonuc.ToString();
        }
    }
}
