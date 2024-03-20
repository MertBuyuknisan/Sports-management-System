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
    public partial class adminGiris : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public adminGiris()
        {
            InitializeComponent();
        }

        private void adminGirisBtn_Click(object sender, EventArgs e)
        {
            if (adminkAdtxt.Text == "" || adminSifretxt.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM admin", baglantı);
                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    string dbKullaniciAdi = reader["admin_kullanıcıAd"].ToString();
                    string dbSifre = reader["admin_sifre"].ToString();

                    if (string.Equals(adminkAdtxt.Text, dbKullaniciAdi, StringComparison.Ordinal) && adminSifretxt.Text == dbSifre)
                    {
                        AdminPaneli adminPaneli = new AdminPaneli();
                        adminPaneli.Show();
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
            anaSayfaForm anasayfaForm=new anaSayfaForm();
            anasayfaForm.Show();
            this.Hide();
        }

       
    }
}
