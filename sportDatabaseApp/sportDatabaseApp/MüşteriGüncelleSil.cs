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
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace sportDatabaseApp
{
    public partial class MüşteriGüncelleSil : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public MüşteriGüncelleSil()
        {
            InitializeComponent();
        }

        private void MüşteriGüncelleSil_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select musteri_id as 'Müşteri ID', musteri_ad as 'Müşteri Adı',musteri_soyad as 'Müşteri Soyadı',musteri_tc as 'Müşteri T.C',musteri_tel as 'Telefon',musteri_cinsiyet as 'Cinsiyet',musteri_ucret as 'Aylık Ücret',musteri_girisTarihi as 'Başlangıç',musteri_cıkısTarihi as 'Bitiş' from musteriler ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo= new DataTable();   
            adp.Fill(tablo);
            müsteriGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
        }
        private void geriBtn_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            adminPaneli.Show();
            this.Hide();
        }
        private void müsteriGüncelleSildgw_DoubleClick(object sender, EventArgs e)
        {
            int secim = müsteriGüncelleSildgw.SelectedCells[0].RowIndex;
            musteriGüncelleIDtxt.Text = müsteriGüncelleSildgw.Rows[secim].Cells[0].Value.ToString();
            müsteriGüncelleAdtxt.Text = müsteriGüncelleSildgw.Rows[secim].Cells[1].Value.ToString();
            müsteriGüncelleSoyadtxt.Text = müsteriGüncelleSildgw.Rows[secim].Cells[2].Value.ToString();
            müsteriGüncelleTCtxt.Text = müsteriGüncelleSildgw.Rows[secim].Cells[3].Value.ToString();
            müsteriGüncelleTlf.Text = müsteriGüncelleSildgw.Rows[secim].Cells[4].Value.ToString();
            müsteriGüncelleCinsiyet.Text = müsteriGüncelleSildgw.Rows[secim].Cells[5].Value.ToString();
            müsteriGüncelleFiyattxt.Text = müsteriGüncelleSildgw.Rows[secim].Cells[6].Value.ToString();
            müsteriGüncelleBaslangic.Text = müsteriGüncelleSildgw.Rows[secim].Cells[7].Value.ToString();
            MüsteriGüncelleBitis.Text = müsteriGüncelleSildgw.Rows[secim].Cells[8].Value.ToString();

        }

        private void müsteriSilBtn_Click(object sender, EventArgs e)
        {
           
          baglantı.Open();

            SqlCommand komut = new SqlCommand("Delete from musteriler where musteri_id=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", musteriGüncelleIDtxt.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri Başarıyla Silindi.");
            komut.CommandText = "Select musteri_id as 'Müşteri ID', musteri_ad as 'Müşteri Adı',musteri_soyad as 'Müşteri Soyadı',musteri_tc as 'Müşteri T.C',musteri_tel as 'Telefon',musteri_cinsiyet as 'Cinsiyet',musteri_ucret as 'Aylık Ücret',musteri_girisTarihi as 'Başlangıç',musteri_cıkısTarihi as 'Bitiş' from musteriler ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            müsteriGüncelleSildgw.DataSource = tablo;

        }
  
        private void temizlebtn_Click_1(object sender, EventArgs e)
        {
            musteriGüncelleIDtxt.Text = "";
            musteriGüncelleIDtxt.Text = "";
            müsteriGüncelleAdtxt.Text = "";
            müsteriGüncelleSoyadtxt.Text = "";
            müsteriGüncelleTCtxt.Text = "";
            müsteriGüncelleTlf.Text = "";
            müsteriGüncelleCinsiyet.Text = "";
            müsteriGüncelleFiyattxt.Text = "";
            müsteriGüncelleBaslangic.Text = "";
            MüsteriGüncelleBitis.Text = "";
        }

        private void müsteriGüncellebtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update musteriler set musteri_ad=@musteri_ad," +
                "musteri_soyad=@musteri_soyad,musteri_tc=@musteri_tc,musteri_tel=@musteri_tel,musteri_cinsiyet=@musteri_cinsiyet,musteri_ucret=@musteri_ucret,musteri_girisTarihi=@musteri_girisTarihi,musteri_cıkısTarihi=@musteri_cıkısTarihi where musteri_id=@musteri_id", baglantı);
            int secilenid = Convert.ToInt32(müsteriGüncelleSildgw.CurrentRow.Cells[0].Value);

            komut.Parameters.AddWithValue("@musteri_id", secilenid);
            komut.Parameters.AddWithValue("@musteri_ad", müsteriGüncelleAdtxt.Text);
            komut.Parameters.AddWithValue("@musteri_soyad", müsteriGüncelleSoyadtxt.Text);
            komut.Parameters.AddWithValue("@musteri_tc", müsteriGüncelleTCtxt.Text);
            komut.Parameters.AddWithValue("@musteri_tel", müsteriGüncelleTlf.Text);
            komut.Parameters.AddWithValue("@musteri_cinsiyet", müsteriGüncelleCinsiyet.Text);
            komut.Parameters.AddWithValue("@musteri_girisTarihi", müsteriGüncelleBaslangic.Value);
            komut.Parameters.AddWithValue("@musteri_ucret", müsteriGüncelleFiyattxt.Text);
            komut.Parameters.AddWithValue("@musteri_cıkısTarihi", MüsteriGüncelleBitis.Value);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri Başarıyla Güncellendi.");
            komut.CommandText = "Select musteri_id as 'Müşteri ID', musteri_ad as 'Müşteri Adı',musteri_soyad as 'Müşteri Soyadı',musteri_tc as 'Müşteri T.C',musteri_tel as 'Telefon',musteri_cinsiyet as 'Cinsiyet',musteri_ucret as 'Aylık Ücret',musteri_girisTarihi as 'Başlangıç',musteri_cıkısTarihi as 'Bitiş' from musteriler ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            müsteriGüncelleSildgw.DataSource = tablo;
        }

        private void MüsteriGüncelleBitis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime giristarihi = Convert.ToDateTime(müsteriGüncelleBaslangic.Text);
            DateTime bitistarihi = Convert.ToDateTime(MüsteriGüncelleBitis.Text);
            TimeSpan toplamgün = bitistarihi - giristarihi;
            string deger = toplamgün.TotalDays.ToString();
            int totalücret = Convert.ToInt32(deger) * 70;
            müsteriGüncelleFiyattxt.Text = totalücret.ToString();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select musteri_id as 'Müşteri ID', musteri_ad as 'Müşteri Adı',musteri_soyad as 'Müşteri Soyadı',musteri_tc as 'Müşteri T.C',musteri_tel as 'Telefon',musteri_cinsiyet as 'Cinsiyet',musteri_ucret as 'Aylık Ücret',musteri_girisTarihi as 'Başlangıç',musteri_cıkısTarihi as 'Bitiş' from musteriler  where musteri_ad='" + egitmenAdAratxt.Text + "' ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            müsteriGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select musteri_id as 'Müşteri ID', musteri_ad as 'Müşteri Adı',musteri_soyad as 'Müşteri Soyadı',musteri_tc as 'Müşteri T.C',musteri_tel as 'Telefon',musteri_cinsiyet as 'Cinsiyet',musteri_ucret as 'Aylık Ücret',musteri_girisTarihi as 'Başlangıç',musteri_cıkısTarihi as 'Bitiş' from musteriler";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            müsteriGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
            egitmenAdAratxt.Text = "";
        }
    }
}
