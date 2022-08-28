using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int karaktersayisi = textBox1.Text.Length;
            string yeni_ifade = "";
            for (int i = 0; i <= karaktersayisi - 1; i++)
            {
                if (char.IsLower(textBox1.Text[i]) == true)
                    yeni_ifade += textBox1.Text[i].ToString().ToUpper();
                else
                    yeni_ifade += textBox1.Text[i].ToString().ToLower();
            }
            textBox2.Text = yeni_ifade;
        }
    }
}
