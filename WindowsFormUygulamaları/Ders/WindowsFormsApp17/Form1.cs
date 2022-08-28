using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Uygulama 1
        
        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = Convert.ToInt32(textBox3.Text);
            //dizi tanımlama 
            int[] dizim = new int[3] {s1,s2,s3};
            int gecici = 0;
            //sırala
            for (int i = 0; i < dizim.Length; i++)
            {
                for (int j = 0 ; j < dizim.Length; j++)
                {
                    if (dizim[i]<dizim[j]) 
                    {
                        gecici = dizim[j];
                        dizim[j] = dizim[i];
                        dizim[i] = gecici;
                    }
                }
            }
            //textbox4 e yazdır
            foreach (var item in dizim)
            {
                textBox4.Text += item+ "<";
            }
        }
        
        //Uygulama 2
        
        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rastgele = new Random();
            int gelen = rastgele.Next(1, 3);
            if (gelen == 1 )
            {
                pictureBox2.BackgroundImage = Image.FromFile("yazı.png");
                //Zamanlayıcı Ekleyip ArkaArka ya gelmesini sağlıyoz.
                //System.Threading.Thread.Sleep(3000); //
                //pictureBox2.BackgroundImage = Image.FromFile("tura.png");
                //System.Threading.Thread.Sleep(3000); //
                //pictureBox2.BackgroundImage = Image.FromFile("yazı.png");
                //System.Threading.Thread.Sleep(3000); //
                //pictureBox2.BackgroundImage = Image.FromFile("tura.png");
                //System.Threading.Thread.Sleep(3000); //
                //pictureBox2.BackgroundImage = Image.FromFile("yazı.png");
            }
            else
            {
                pictureBox2.BackgroundImage = Image.FromFile("tura.png");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Yanlış açıldı
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Emin misiniz ?","Program Kapanıyor",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        //Uygulama 3 
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            for (int i = 0; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
            }   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "";
            label4.ForeColor = Color.Purple;
            int sayi = Convert.ToInt32(comboBox1.SelectedItem);
            for (int i = 0; i <= 10; i++)
            {
                lng()+"\n";
            }abel4.Text += i +" "+ "x"+ " " + sayi + " " + "=" + " " + (i * sayi).ToStri
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
