using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            label4.Text = (s1 * s2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuç = 0; 
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            label4.Text = (s1 + s2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            label4.Text = (s1 - s2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            label4.Text = (s1 / s2).ToString();
        }
    }
}
