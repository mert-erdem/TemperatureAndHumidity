﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SıcaklıkNem
{
    public partial class Formchild : Form
    {
        public Formchild()
        {
            InitializeComponent();
            
        }
        
        public int kacdegergeldi;
        public int sayac=0;
        public int deger;
        public int control=1;
        
        

        public float ortalama=0;
        public float toplam;
        public int max = 0;
        public int min = 10000;
        
        

        private void Formchild_Load(object sender, EventArgs e)
        {
    
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(deger.ToString());
            toplam += deger;
            ortalama = toplam / kacdegergeldi;
            textBox1.Text = ortalama.ToString();

            if(deger>max)
            {
                max = deger;
                textBox2.Text = deger.ToString();
            }
            if(deger<min && deger>0)
            {
                min = deger;
                textBox3.Text = deger.ToString();
            }

            chart1.Series["Sıcaklık"].Points.AddY(deger);
            





            
            
                
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
