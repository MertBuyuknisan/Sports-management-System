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

namespace sportDatabaseApp
{
    public partial class egitmenGiris : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public egitmenGiris()
        {
            InitializeComponent();
        }

        private void egitmenGirisBtn_Click(object sender, EventArgs e)
        {
            if (egitmenkAdtxt.Text == "" || egitmenSifretxt.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM egitmenler", baglantı);
                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    string dbKullaniciAdi = reader["egitmen_kullanıcıAd"].ToString();
                    string dbSifre = reader["egitmen_sifre"].ToString();

                    if (string.Equals(egitmenkAdtxt.Text, dbKullaniciAdi, StringComparison.Ordinal) && egitmenSifretxt.Text == dbSifre)
                    {
                        EgitmenPaneli egitmenPaneli = new EgitmenPaneli();
                        egitmenPaneli.Show();
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
