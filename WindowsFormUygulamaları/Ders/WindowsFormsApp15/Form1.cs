using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maas = Convert.ToInt32(textBox1.Text);
            int zamorani = Convert.ToInt32(textBox2.Text);
            int prim = Convert.ToInt32(textBox3.Text);
            double zammiktari = maas / 100 * zamorani;
            label4.Text = zammiktari.ToString();
            label5.Text = (maas + prim + zammiktari).ToString();
        }
    }
}
