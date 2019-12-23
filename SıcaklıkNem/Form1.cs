using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;



namespace SıcaklıkNem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        public int kacsicaklik;
        public int kacnem;
        public int i = 0;
        public int k = 0;
        public int saniye=0;

        public int[] dizi = new int[1000];
        public int[] dizi2 = new int[1000];
        
        
        Random rast = new Random();
        Formchild2 ac2 = new Formchild2();
        Formchild ac = new Formchild();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ac.timer2.Enabled = true;
            ac2.timer3.Enabled = true;
            ac.label5.Text = DateTime.Now.ToString();
            ac2.label5.Text = DateTime.Now.ToString();




        }

        private void sıcaklıkVerileriniGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ac.MdiParent = this;
           
            ac.kacdegergeldi = kacsicaklik;
            
            ac.Show();
        }

        private void biçimlendirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void nemVerilerininGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ac2.MdiParent = this;

            ac2.kacdegergeldi = kacsicaklik;

            ac2.Show();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {


            dizi[i] = rast.Next(10, 25);
            ac.deger = dizi[i];
            kacsicaklik++;
            ac.kacdegergeldi=kacsicaklik;

            dizi2[i] = rast.Next(0, 100);
            ac2.deger = dizi2[i];
            kacsicaklik++;
            ac2.kacdegergeldi = kacsicaklik;

            
            ac.label7.Text = (saniye / 60).ToString()+":"+(saniye%60).ToString();
            
            ac2.label7.Text = (saniye / 60).ToString() + ":" + (saniye % 60).ToString();

            saniye++;

            i++;
            
        
            
        }

        private void similasyonuDurdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = false;
            ac.timer2.Enabled = false;
            ac2.timer3.Enabled = false;
            

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
