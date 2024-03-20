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
    public partial class EgitmenEkle : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public EgitmenEkle()
        {
            InitializeComponent();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            adminPaneli.Show();
            this.Hide();
        }

        private void egitmenEklebtn_Click(object sender, EventArgs e)
        {
            if (egitmenEkleAdtxt.Text == "" || egitmenEkleSoyadtxt.Text == "" || egitmenEklekAdtxt.Text == "" || egitmenEkleSifretxt.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into egitmenler (egitmen_ad,egitmen_soyad,egitmen_kullanıcıAd,egitmen_sifre,egitmen_yas,egitmen_cinsiyet,verilen_ders)values('" + egitmenEkleAdtxt.Text + "','" + egitmenEkleSoyadtxt.Text + "','" + egitmenEklekAdtxt.Text + "','" + egitmenEkleSifretxt.Text +"','"+egitmenEkleYastxt.Text+"','"+egitmenEklecb.Text+"','"+egitmenEkleAlantxt.Text+"')", baglantı);
                baglantı.Open();
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Eğitmen Kaydı Yapıldı.");
                egitmenEkleAdtxt.Text = "";
                egitmenEkleSoyadtxt.Text = "";
                egitmenEklekAdtxt.Text = "";
                egitmenEkleSifretxt.Text = "";
                egitmenEkleAlantxt.Text = "";
                egitmenEkleYastxt.Text = "";
                egitmenEklecb.Text = "";
            }
        }

        private void egitmenEkleSıfırlabtn_Click(object sender, EventArgs e)
        {
            egitmenEkleAdtxt.Text = "";
            egitmenEkleSoyadtxt.Text = "";
            egitmenEklekAdtxt.Text = "";
            egitmenEkleSifretxt.Text = "";
            egitmenEkleAlantxt.Text = "";
            egitmenEkleYastxt.Text = "";
            egitmenEklecb.Text = "";
        }
    }
}
