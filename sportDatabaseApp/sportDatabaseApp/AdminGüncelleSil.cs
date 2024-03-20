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
namespace sportDatabaseApp
{
    public partial class AdminGüncelleSil : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public AdminGüncelleSil()
        {
            InitializeComponent();
        }

    

        private void AdminGüncelleSil_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select admin_id as 'Admin ID', admin_ad as 'Admin Adı',admin_soyad as 'Admin Soyadı' from admin ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            adminGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
        }

        

        private void geriBtn_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            adminPaneli.Show();
            this.Hide();
        }

        private void adminSilBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komut = new SqlCommand("Delete from admin where admin_id=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", adminGüncelleIDtxt.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Admin Başarıyla Silindi.");
            komut.CommandText = "Select admin_id as 'Admin ID', admin_ad as 'Admin Adı',admin_soyad as 'Admin Soyadı' from admin ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            adminGüncelleSildgw.DataSource = tablo;
        }

        private void adminGüncellebtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update admin set admin_ad=@admin_ad," +
                "admin_soyad=@admin_soyad,admin_kullanıcıAd=@admin_kullanıcıAd,admin_sifre=@admin_sifre", baglantı);
            int secilenid = Convert.ToInt32(adminGüncelleSildgw.CurrentRow.Cells[0].Value);

            komut.Parameters.AddWithValue("@admin_id", secilenid);
            komut.Parameters.AddWithValue("@admin_ad", adminGüncelleSilAdtxt.Text);
            komut.Parameters.AddWithValue("@admin_soyad", adminGüncelleSilSoyadtxt.Text);
            komut.Parameters.AddWithValue("@admin_kullanıcıAd", adminGüncelleSilkAdtxt.Text);
            komut.Parameters.AddWithValue("@admin_sifre", adminGüncelleSilsifretxt.Text);
           /* komut.Parameters.AddWithValue("@musteri_cinsiyet", müsteriGüncelleCinsiyet.Text);
            komut.Parameters.AddWithValue("@musteri_girisTarihi", müsteriGüncelleBaslangic.Value);
            komut.Parameters.AddWithValue("@musteri_ucret", müsteriGüncelleFiyattxt.Text);
            komut.Parameters.AddWithValue("@musteri_cıkısTarihi", MüsteriGüncelleBitis.Value);*/
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Admin Başarıyla Güncellendi.");
            komut.CommandText = "Select admin_id as 'Admin ID', admin_ad as 'Admin Adı',admin_soyad as 'Admin Soyadı',admin_kullanıcıAd as 'Kullanıcı Ad',admin_sifre as 'Şifre' from admin ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            adminGüncelleSildgw.DataSource = tablo;
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            adminGüncelleIDtxt.Text = "";
            adminGüncelleSilAdtxt.Text = "";
            adminGüncelleSilSoyadtxt.Text = "";
            adminGüncelleSilkAdtxt.Text = "";
            adminGüncelleSilsifretxt.Text = "";
        }

        private void adminGüncelleSildgw_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secim = adminGüncelleSildgw.SelectedCells[0].RowIndex;
            adminGüncelleIDtxt.Text = adminGüncelleSildgw.Rows[secim].Cells[0].Value.ToString();
            adminGüncelleSilAdtxt.Text = adminGüncelleSildgw.Rows[secim].Cells[1].Value.ToString();
            adminGüncelleSilSoyadtxt.Text = adminGüncelleSildgw.Rows[secim].Cells[2].Value.ToString();
            /*müsteriGüncelleTCtxt.Text = müsteriGüncelleSildgw.Rows[secim].Cells[3].Value.ToString();
            müsteriGüncelleTlf.Text = müsteriGüncelleSildgw.Rows[secim].Cells[4].Value.ToString();
            müsteriGüncelleCinsiyet.Text = müsteriGüncelleSildgw.Rows[secim].Cells[5].Value.ToString();
            müsteriGüncelleFiyattxt.Text = müsteriGüncelleSildgw.Rows[secim].Cells[6].Value.ToString();
            müsteriGüncelleBaslangic.Text = müsteriGüncelleSildgw.Rows[secim].Cells[7].Value.ToString();
            MüsteriGüncelleBitis.Text = müsteriGüncelleSildgw.Rows[secim].Cells[8].Value.ToString();*/
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select admin_id as 'Admin ID', admin_ad as 'Admin Adı',admin_soyad as 'Admin Soyadı',admin_kullanıcıAd as 'Kullanıcı Ad',admin_sifre as 'Şifre' from admin   where admin_ad='" + egitmenAdAratxt.Text + "' ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            adminGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select admin_id as 'Admin ID', admin_ad as 'Admin Adı',admin_soyad as 'Admin Soyadı',admin_kullanıcıAd as 'Kullanıcı Ad',admin_sifre as 'Şifre' from admin ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            adminGüncelleSildgw.DataSource = tablo;
            baglantı.Close();
            egitmenAdAratxt.Text = "";
        }
    }
}
