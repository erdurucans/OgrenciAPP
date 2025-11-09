namespace OgrenciAPP
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ogrenciFormu = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ögrenciİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // menu_cikis
            // 
            this.menu_cikis.Name = "menu_cikis";
            this.menu_cikis.Size = new System.Drawing.Size(180, 22);
            this.menu_cikis.Text = "&Cıkış";
            this.menu_cikis.Click += new System.EventHandler(this.menu_cikis_Click);
            // 
            // ögrenciİşlemleriToolStripMenuItem
            // 
            this.ögrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ogrenciFormu});
            this.ögrenciİşlemleriToolStripMenuItem.Name = "ögrenciİşlemleriToolStripMenuItem";
            this.ögrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ögrenciİşlemleriToolStripMenuItem.Text = "Ögrenci İşlemleri";
            // 
            // menu_ogrenciFormu
            // 
            this.menu_ogrenciFormu.Name = "menu_ogrenciFormu";
            this.menu_ogrenciFormu.Size = new System.Drawing.Size(180, 22);
            this.menu_ogrenciFormu.Text = "Öğrenci &Formu";
            this.menu_ogrenciFormu.Click += new System.EventHandler(this.menu_ogrenciFormu_Click);
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(226, 173);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(35, 13);
            this.lbl_KullaniciAdi.TabIndex = 2;
            this.lbl_KullaniciAdi.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ögrenci APP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_cikis;
        private System.Windows.Forms.ToolStripMenuItem ögrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_ogrenciFormu;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
    }
}

