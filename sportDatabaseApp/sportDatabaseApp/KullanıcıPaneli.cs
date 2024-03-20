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
    public partial class KullanıcıPaneli : Form
    {
        public KullanıcıPaneli()
        {
            InitializeComponent();
        }

        private void sporBilgileri_Click(object sender, EventArgs e)
        {
            SporBilgileri sporBilgileri = new SporBilgileri();
            sporBilgileri.Show();
            this.Hide();
        }

        private void KullanıcıPanelEgitmenBilgi_Click(object sender, EventArgs e)
        {
            EgitmenBilgi egitmenBilgi=new EgitmenBilgi();
            egitmenBilgi.Show();
            this.Hide();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            anaSayfaForm anaSayfaForm= new anaSayfaForm();
            anaSayfaForm.Show();
            this.Hide();
        }
    }
}
