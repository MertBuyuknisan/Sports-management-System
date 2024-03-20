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
    public partial class EgitmenBilgi : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public EgitmenBilgi()
        {
            InitializeComponent();
        }

        private void EgitmenBilgi_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',verilen_ders as 'Uzmanlık Alanı',egitmen_yas as 'Yaş',egitmen_cinsiyet as 'Cinsiyet'from egitmenler";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            KullanıcıPaneli kullanıcıPaneli=new KullanıcıPaneli();
            this.Hide();
            kullanıcıPaneli.Show();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',verilen_ders as 'Uzmanlık Alanı',egitmen_yas as 'Yaş',egitmen_cinsiyet as 'Cinsiyet' from egitmenler where egitmen_ad='" + egitmenAdAratxt.Text + "' ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',verilen_ders as 'Uzmanlık Alanı',egitmen_yas as 'Yaş',egitmen_cinsiyet as 'Cinsiyet'from egitmenler";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
            egitmenAdAratxt.Text = "";
        }
    }
}
