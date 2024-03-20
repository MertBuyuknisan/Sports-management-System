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


namespace sportDatabaseApp
{
    public partial class anaSayfaForm : Form
    {
        public anaSayfaForm()
        {
            InitializeComponent();
        }
        public string connection = "Data Source=HPGAMING\\SQLEXPRESS;Initial Catalog=SporOtomasyon;Integrated Security=True;Trust Server Certificate=True";

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            adminGiris adminGiris = new adminGiris();
            adminGiris.Show();
            this.Hide();
        }

        private void kullaniciPanelBtn_Click(object sender, EventArgs e)
        {
            kullaniciGiris kullaniciGiris = new kullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }

        private void egitmenPanelBtn_Click(object sender, EventArgs e)
        {
            egitmenGiris egitmenGiris = new egitmenGiris();
            egitmenGiris.Show();
            this.Hide();
        }

      
    }
}
