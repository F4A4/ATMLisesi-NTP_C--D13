using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SınavaCalısmaMetot2
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
        public void Metot1()
        {
            MessageBox.Show("NABER KANKA ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metot1();
        }
        public int Metot2()
        {
            return 4 * 5;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = Metot2();
            MessageBox.Show(sonuc.ToString());
        }
        public void Metot3(int s1, int s2)
        {
            MessageBox.Show((s1*s2).ToString());
 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Metot3(5,6);

        }
        public int Metot4(int s3,int s4)
        {
            return s3 * s4;
 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int sonuc2 = Metot4(6,7);
            
            MessageBox.Show(sonuc2.ToString());
        }
    }
}
