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
    public partial class EgitmenGüncelleSil : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public EgitmenGüncelleSil()
        {
            InitializeComponent();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            
                AdminPaneli adminPaneli = new AdminPaneli();
                adminPaneli.Show();
                this.Hide();
            
        }

        private void EgitmenGüncelleSil_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',egitmen_yas as 'Eğitmen Yaşı',egitmen_cinsiyet as 'Cinsiyet',verilen_ders as 'Verilen Ders' from egitmenler ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            egitmenGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
        }

        

        private void müsteriSilBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komut = new SqlCommand("Delete from egitmenler where egitmen_id=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", egimenGüncelleIDtxt.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Eğitmen Başarıyla Silindi.");
            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',egitmen_yas as 'Yaş',egitmen_cinsiyet as 'Cinsiyet',verilen_ders as 'Verilen Ders'from egitmenler ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            egitmenGüncelleSildgw.DataSource = tablo;
        }

    

        private void egitmenTemizlebtn_Click(object sender, EventArgs e)
        {
            egimenGüncelleIDtxt.Text = "";
            egitmenGüncelleSoyadtxt.Text = "";
            egitmenGüncelleAdtxt.Text = "";
            egitmenGüncelleAlancb.Text = "";
            egitmenGüncelleCinsyetcb.Text = "";
            EgitmenGüncelleYastxt.Text = "";
        }

        private void egitmenGüncellebtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update egitmenler set egitmen_ad=@egitmen_ad," +
               "egitmen_soyad=@egitmen_soyad,egitmen_yas=@egitmen_yas,egitmen_cinsiyet=@egitmen_cinsiyet,verilen_ders=@verilen_ders where egitmen_id=@egitmen_id", baglantı);
            int secilenid = Convert.ToInt32(egitmenGüncelleSildgw.CurrentRow.Cells[0].Value);

            komut.Parameters.AddWithValue("@egitmen_id", secilenid);
            komut.Parameters.AddWithValue("@egitmen_ad", egitmenGüncelleAdtxt.Text);
            komut.Parameters.AddWithValue("@egitmen_soyad", egitmenGüncelleSoyadtxt.Text);
            komut.Parameters.AddWithValue("@egitmen_yas", EgitmenGüncelleYastxt.Text);
            komut.Parameters.AddWithValue("@egitmen_cinsiyet", egitmenGüncelleCinsyetcb.Text);
            komut.Parameters.AddWithValue("@verilen_ders", egitmenGüncelleAlancb.Text);

            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Eğitmen Başarıyla Güncellendi.");
            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',egitmen_yas as 'Yaş',egitmen_cinsiyet as 'Cinsiyet',verilen_ders as 'Verilen Ders'from egitmenler ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            egitmenGüncelleSildgw.DataSource = tablo;
        }

        private void egitmenGüncelleSildgw_DoubleClick(object sender, EventArgs e)
        {
            int secim = egitmenGüncelleSildgw.SelectedCells[0].RowIndex;
            egimenGüncelleIDtxt.Text = egitmenGüncelleSildgw.Rows[secim].Cells[0].Value.ToString();
            egitmenGüncelleAdtxt.Text = egitmenGüncelleSildgw.Rows[secim].Cells[1].Value.ToString();
            egitmenGüncelleSoyadtxt.Text = egitmenGüncelleSildgw.Rows[secim].Cells[2].Value.ToString();
            EgitmenGüncelleYastxt.Text = egitmenGüncelleSildgw.Rows[secim].Cells[3].Value.ToString();
            egitmenGüncelleCinsyetcb.Text = egitmenGüncelleSildgw.Rows[secim].Cells[4].Value.ToString();
            egitmenGüncelleAlancb.Text = egitmenGüncelleSildgw.Rows[secim].Cells[5].Value.ToString();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',egitmen_yas as 'Yaş',egitmen_cinsiyet as 'Cinsiyet',verilen_ders as 'Verilen Ders'from egitmenler  where egitmen_ad='" + egitmenAdAratxt.Text+"' ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            egitmenGüncelleSildgw.DataSource = tablo;
            baglantı.Close();

        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select egitmen_id as 'Eğitmen ID', egitmen_ad as 'Eğitmen Adı',egitmen_soyad as 'Eğitmen Soyadı',egitmen_yas as 'Yaş',egitmen_cinsiyet as 'Cinsiyet',verilen_ders as 'Verilen Ders'from egitmenler";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            egitmenGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
            egitmenAdAratxt.Text = "";
        }
    }
}
