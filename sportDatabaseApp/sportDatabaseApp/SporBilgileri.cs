﻿using System;
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
    public partial class SporBilgileri : Form
    {
        public SporBilgileri()
        {
            InitializeComponent();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            KullanıcıPaneli kullanıcıPaneli=new KullanıcıPaneli();
            this.Hide();
            kullanıcıPaneli.Show();
        }
    }
}
