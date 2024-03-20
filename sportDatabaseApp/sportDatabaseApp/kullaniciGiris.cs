using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Reflection;

namespace sportDatabaseApp
{
    public partial class kullaniciGiris : Form
    { 
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public kullaniciGiris()
        {
            InitializeComponent();
        }
       
        private void kullaniciGirisBtn_Click(object sender, EventArgs e)
        {

            if (kullaniciAdtxt.Text == "" || kullaniciSifretxt.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM musteriler", baglantı);
                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    string dbKullaniciAdi = reader["musteri_kullanıcıAd"].ToString();
                    string dbSifre = reader["musteri_sifre"].ToString();

                    if (string.Equals(kullaniciAdtxt.Text, dbKullaniciAdi, StringComparison.Ordinal) && kullaniciSifretxt.Text == dbSifre)
                    {
                        KullanıcıPaneli kullanıcıPaneli=new KullanıcıPaneli();
                        kullanıcıPaneli.Show();
                        this.Hide();
                        baglantı.Close();
                        return;
                    }
                }

                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                baglantı.Close();
            }


        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            anaSayfaForm anasayfaForm = new anaSayfaForm();
            anasayfaForm.Show();
            this.Hide();
        }

     
    }
}
