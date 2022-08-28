using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int elemansayisi = listBox1.Items.Count;
            string[] listele = new string[elemansayisi];
            for (int i = 0; i < elemansayisi; i++)
            {
                listele[i] = listBox1.Items[i].ToString();
            }
            Array.Sort(listele);//a dan z ye doğru
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < listele.Length; i++)
                {
                    listBox1.Items.Add(listele[i]);
                }
            }
            else
            {
                Array.Reverse(listele);//z den a ya sıraladım.
                listBox1.Items.Clear(); 

            for (int i = 0; i < listele.Length; i++)
                {
                    listBox1.Items.Add(listele[i]);
                }
            }
        }
    }
}

