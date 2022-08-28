using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string deger;
        
        private void button1_Click(object sender, EventArgs e)
        {
            deger = textBox1.Text;
            Form2 frm2 = new Form2();
            //frm2.Show(); Arkadaki form Kullanılabilir .
            frm2.ShowDialog(); //Arkadaki Form Kullanılamaz .
        }

        //ücret
        //ebeta göre = en x boy x yıkseklik x mesafe x 0.00001 + 9
        //ağırlığa göre = ağırlık x mesafe x0.005 + 10 
        //Bunlardan hangisi yüksekse o üçret olacak 
        //anlaşmalı firmalara %20 indirim yapılacak 
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double en = Convert.ToDouble(textBox2.Text);
            double boy = Convert.ToDouble(textBox3.Text);
            double mesafe = Convert.ToDouble(textBox4.Text);
            double yukseklık = Convert.ToDouble(textBox5.Text);
            double agırlık = Convert.ToDouble(textBox6.Text);
            double ebatagoreucret = en * boy * yukseklık * mesafe * 0.00001 + 9;
            double agırlıgagöreucret = agırlık * mesafe * 0.005 + 10;
            double ucret = agırlıgagöreucret;
            if (ebatagoreucret > agırlıgagöreucret)
            {
                ucret = ebatagoreucret;
            }
            if (checkBox1.Checked)
            {
                ucret = ucret * 0.8;
            }
            label8.Text = ucret.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime baslangıc = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime bıtıs = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan fark = bıtıs - baslangıc;
            label20.Text = Math.Round((fark.TotalDays / 365.25), 2).ToString();
            label19.Text = Math.Round((fark.TotalDays / 30.2), 2).ToString();
            label18.Text = fark.TotalDays.ToString();
            label17.Text = fark.TotalHours.ToString();
            label16.Text = fark.TotalMinutes.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           DialogResult labelSonuc = colorDialog1.ShowDialog();
           label21.BackColor = colorDialog1.Color;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult FormSonuc = colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void formunArkaPlanıDeğiştirinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult FormSonuc = colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void metninArkaPlanRenginiDeğiştirinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult labelSonuc = colorDialog1.ShowDialog();
            label21.BackColor = colorDialog1.Color;
        }
    }
}
