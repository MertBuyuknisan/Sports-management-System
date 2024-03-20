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
using System.IO;

namespace sportDatabaseApp
{
  
    public partial class AdminPanelEkle : Form
    {
       
         

    SqlConnection baglantı = new SqlConnection("Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True");
        public AdminPanelEkle()
        {
            InitializeComponent();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            adminPaneli.Show();
            this.Hide();

        }

        private void adminPanelEklebtn_Click(object sender, EventArgs e)
        {
            if (adminEkleAdtxt.Text == "" || adminEkleKadtxt.Text == "" || adminEkleSifretxt.Text == "" || adminEkleSoyadtxt.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into admin (admin_ad,admin_soyad,admin_kullanıcıAd,admin_sifre) values('" + adminEkleAdtxt.Text + "','" + adminEkleSoyadtxt.Text + "','" + adminEkleKadtxt.Text + "','" + adminEkleSifretxt.Text + "')", baglantı);
                baglantı.Open();
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Admin Kaydı Yapıldı.");
                adminEkleAdtxt.Text = "";
                adminEkleKadtxt.Text = "";
                adminEkleSifretxt.Text = "";
                adminEkleSoyadtxt.Text = "";
                
            }
        }

       
    }
}
