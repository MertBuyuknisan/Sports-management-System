using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportDatabaseApp
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void yeniMüsteriBtn_Click(object sender, EventArgs e)
        {
            MüşteriEkle müşteriEkle=new MüşteriEkle();
            müşteriEkle.Show();
            this.Hide();
        }

      

        private void müsteriGüncelleBtn_Click(object sender, EventArgs e)
        {
            MüşteriGüncelleSil müşteriGüncelle=new MüşteriGüncelleSil();
            müşteriGüncelle.Show();
            this.Hide();
        }

        private void adminPanelEkle_Click(object sender, EventArgs e)
        {
            AdminPanelEkle adminPanelEkle= new AdminPanelEkle();
            adminPanelEkle.Show();
            this.Hide();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {

        }

        private void adminGüncelleSilbtn_Click(object sender, EventArgs e)
        {
            AdminGüncelleSil adminGüncelleSil = new AdminGüncelleSil();
            adminGüncelleSil.Show();
            this.Hide();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            anaSayfaForm anasayfaForm = new anaSayfaForm();
            anasayfaForm.Show();
            this.Hide();
        }

        private void egitmenEklebtn_Click(object sender, EventArgs e)
        {
            EgitmenEkle egitmenEkle = new EgitmenEkle();
            egitmenEkle.Show();
            this.Hide();
        }

        private void egitmenGüncelleSilbtn_Click(object sender, EventArgs e)
        {
            EgitmenGüncelleSil egitmenGüncelleSil = new EgitmenGüncelleSil();
            egitmenGüncelleSil.Show();  
            this.Hide();
        }
    }
}
