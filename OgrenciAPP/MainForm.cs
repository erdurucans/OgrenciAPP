using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciAPP
{
    public partial class MainForm : Form
    {
        private User aktifKullanici;
     //   public string GirisYapanKullanici { get; set; }

        public MainForm( User kullanici)
        {
            InitializeComponent();
            aktifKullanici = kullanici;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_KullaniciAdi.Text = $"Hoş Geldiniz, {aktifKullanici.FullName} ({aktifKullanici.Role})";
        }

        private void menu_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void menu_ogrenciFormu_Click(object sender, EventArgs e)
        {
            OgrenciForm frm = new OgrenciForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
