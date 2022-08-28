using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Göster_Click(object sender, EventArgs e)
        {
            int ilkboslukkarakteri = textBox1.Text.IndexOf(' ');
            int sonboslukkarakteri = textBox1.Text.LastIndexOf(' ');
            string ilkkelime = textBox1.Text.Substring(0,ilkboslukkarakteri);
            string sonkelime = textBox1.Text.Substring(sonboslukkarakteri, textBox1.Text.Length - sonboslukkarakteri);
            label2.Text =/*"ilk boşluk :" +ilkboslukkarakteri + "\n\r"+"son boşluk karakteri :" +sonboslukkarakteri + "\n\r"+ */
                "ilk kelime :" + ilkkelime + "\n\r" + "son kelime :" + sonkelime;
            int kelimesay = textBox1.Text.Split(' ').Length;
            string ilkkelime2 = textBox1.Text.Split(' ')[0];
            string sonkelime2 = textBox1.Text.Split(' ')[kelimesay - 1];
            label3.Text = "ilk kelime = " + ilkkelime2 + "\n\r" + "son kelime :" + sonkelime2;   
        }
    }
}
