using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciAPP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=OgrenciDB;Integrated Security=true";

            string kullaniciAdi = txt_Username.Text;
            string sifre = txt_Password.Text;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open(); 
                SqlCommand cmd = new SqlCommand("select * from Users Where UserName=@u AND Password=@p",conn);
                cmd.Parameters.AddWithValue("@u", kullaniciAdi);
                cmd.Parameters.AddWithValue("@p", sifre);

                SqlDataReader dr =  cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Nesne oluşturuluyor
                    User aktifKullanici = new User();
                    aktifKullanici.UserId = (int) dr["UserID"];
                    aktifKullanici.UserName = dr["UserName"].ToString();
                    aktifKullanici.FullName = dr["FullName"].ToString();
                    aktifKullanici.Role = dr["Role"].ToString();

                    MainForm frm = new MainForm(aktifKullanici);
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }

            }

            //Veritabanı olmadan kontrol edelim
            //if(kullaniciAdi=="admin" && sifre == "123")
            //{
            //    MessageBox.Show("Giriş Başarılı");


            //    //Forma veri aktarma işlemi
            //    MainForm frm= new MainForm();
            //    frm.GirisYapanKullanici = kullaniciAdi;
            //    frm.Show();


            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı Adı veya Parolası Hatalıdır!");
            //}
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
