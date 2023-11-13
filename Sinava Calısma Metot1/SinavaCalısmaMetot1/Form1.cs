using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinavaCalısmaMetot1
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
        public double  Soru1( double sayi1)
        {
            double sonuc = (sayi1*sayi1)/(2*sayi1);
            return  sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {                     
            
            double sonuc = Soru1(4);
            textBox2.Text = sonuc.ToString();
            MessageBox.Show(sonuc.ToString());    
        }
        public bool Soru2(int sayi1)
        {
            bool sonuc1;
            if (sayi1%2==0)
            {
                sonuc1 = true;
            }
            else
            {
                sonuc1 = false;
            }

            return  sonuc1 ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool  abc =Soru2(5);
            textBox3.Text = abc.ToString();
            MessageBox.Show(abc.ToString());
        }
        public string Soru3(string metin1, string metin2)
        {

            return metin1 + metin2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin1 =textBox4.Text;
            string metin2 = textBox5.Text;
            textBox1.Text =  metin1  +  metin2 ;
           
            //textBox1.Text=Deger("MERHABA ","DÜNYA");
            MessageBox.Show(textBox1.Text);
        }
        public double Soru4(int sayi5,int sayi6)
        {

            return (2 * 22 / 7 * sayi5 * sayi6) + (2 * 22 / 7 * sayi5 * sayi5);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = Soru4(10, 5).ToString();
            MessageBox.Show(textBox6.Text.ToString());
        }

        
    }
}
