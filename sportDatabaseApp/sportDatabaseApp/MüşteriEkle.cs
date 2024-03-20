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
    public partial class MüşteriEkle : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public MüşteriEkle()
        {
            InitializeComponent();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli= new AdminPaneli();
            adminPaneli.Show();
            this.Hide();
        }

        private void müsteriEkleBitis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime giristarihi = Convert.ToDateTime(müsteriEkleBaslangic.Text);
            DateTime bitistarihi = Convert.ToDateTime(müsteriEkleBitis.Text);
            TimeSpan toplamgün = bitistarihi - giristarihi;
            string deger=toplamgün.TotalDays.ToString();
            int totalücret = Convert.ToInt32(deger) * 70;
            müsteriEkleFiyattxt.Text = totalücret.ToString();

        }

        private void müsteriEkleBtn_Click(object sender, EventArgs e)
        {
            if (müsteriEkleAdtxt.Text=="" || müsteriEkleSoyadtxt.Text=="" || müsteriEkleCinsiyet.Text=="" ||müsteriEkleTctxt.Text=="" || müsteriEkleTlftxt.Text=="")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
  SqlCommand komut = new SqlCommand("insert into musteriler (musteri_ad,musteri_soyad,musteri_tc,musteri_kullanıcıAd,musteri_sifre,musteri_tel,musteri_cinsiyet,musteri_ucret,musteri_girisTarihi,musteri_cıkısTarihi)values('" + müsteriEkleAdtxt.Text+"','"+müsteriEkleSoyadtxt.Text+"','"+müsteriEkleTctxt.Text+"','"+müsteriEklekadtxt.Text+"','"+musteriEklesifretxt.Text+"','"+müsteriEkleTlftxt.Text+ "','"+müsteriEkleCinsiyet.Text+ "','"+müsteriEkleFiyattxt.Text+ "','"+müsteriEkleBaslangic.Value.ToString("yyyy-MM-dd")+"','"+müsteriEkleBitis.Value.ToString("yyyy-MM-dd")+"')",baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı.");
                müsteriEkleAdtxt.Text = "";
                müsteriEkleSoyadtxt.Text = "";
                müsteriEkleCinsiyet.Text = "";
                müsteriEkleFiyattxt.Text = "";
                müsteriEkleTctxt.Text = "";
                musteriEklesifretxt.Text = "";
                müsteriEkleTlftxt.Text = "";
                müsteriEkleBaslangic.Text = "";
                müsteriEkleBitis.Text = "";
                müsteriEklekadtxt.Text = "";
               
            }
            
            
            
          
            
        }

        private void müsteriSıfırlaBtn_Click(object sender, EventArgs e)
        {
            müsteriEkleAdtxt.Text = "";
            müsteriEkleSoyadtxt.Text = "";
            müsteriEkleCinsiyet.Text = "";
            müsteriEkleFiyattxt.Text = "";
            müsteriEkleTctxt.Text = "";
            müsteriEkleTlftxt.Text = "";
            müsteriEkleBaslangic.Text = "";
            müsteriEkleBitis.Text = "";
            müsteriEklekadtxt.Text = "";
            musteriEklesifretxt.Text = "";
        }

       
    }
}
