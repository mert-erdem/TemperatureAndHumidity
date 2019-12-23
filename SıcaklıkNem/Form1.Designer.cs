namespace SıcaklıkNem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.similasyonuDurdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıcaklıkVerileriniGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nemVerilerininGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimlendirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.similasyonuDurdurToolStripMenuItem,
            this.sıcaklıkVerileriniGösterToolStripMenuItem,
            this.nemVerilerininGösterToolStripMenuItem,
            this.biçimlendirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.gösterToolStripMenuItem.Text = "Simülasyonu Başlat";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // similasyonuDurdurToolStripMenuItem
            // 
            this.similasyonuDurdurToolStripMenuItem.Name = "similasyonuDurdurToolStripMenuItem";
            this.similasyonuDurdurToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.similasyonuDurdurToolStripMenuItem.Text = "Simülasyonu Durdur";
            this.similasyonuDurdurToolStripMenuItem.Click += new System.EventHandler(this.similasyonuDurdurToolStripMenuItem_Click);
            // 
            // sıcaklıkVerileriniGösterToolStripMenuItem
            // 
            this.sıcaklıkVerileriniGösterToolStripMenuItem.Name = "sıcaklıkVerileriniGösterToolStripMenuItem";
            this.sıcaklıkVerileriniGösterToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.sıcaklıkVerileriniGösterToolStripMenuItem.Text = "Sıcaklık Verilerini Göster";
            this.sıcaklıkVerileriniGösterToolStripMenuItem.Click += new System.EventHandler(this.sıcaklıkVerileriniGösterToolStripMenuItem_Click);
            // 
            // nemVerilerininGösterToolStripMenuItem
            // 
            this.nemVerilerininGösterToolStripMenuItem.Name = "nemVerilerininGösterToolStripMenuItem";
            this.nemVerilerininGösterToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.nemVerilerininGösterToolStripMenuItem.Text = "Nem Verilerini Göster";
            this.nemVerilerininGösterToolStripMenuItem.Click += new System.EventHandler(this.nemVerilerininGösterToolStripMenuItem_Click);
            // 
            // biçimlendirToolStripMenuItem
            // 
            this.biçimlendirToolStripMenuItem.Name = "biçimlendirToolStripMenuItem";
            this.biçimlendirToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.biçimlendirToolStripMenuItem.Text = "Biçimlendir";
            this.biçimlendirToolStripMenuItem.Click += new System.EventHandler(this.biçimlendirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 510);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hava Durumu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sıcaklıkVerileriniGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nemVerilerininGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biçimlendirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem similasyonuDurdurToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

