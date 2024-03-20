namespace sportDatabaseApp
{
    partial class anaSayfaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfaForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.kullaniciPanelBtn = new System.Windows.Forms.Button();
            this.egitmenPanelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // adminPanelBtn
            // 
            this.adminPanelBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.adminPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminPanelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminPanelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.adminPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPanelBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminPanelBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminPanelBtn.Image")));
            this.adminPanelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.adminPanelBtn.Location = new System.Drawing.Point(12, 174);
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.Size = new System.Drawing.Size(177, 186);
            this.adminPanelBtn.TabIndex = 2;
            this.adminPanelBtn.Text = "Admin Girişi";
            this.adminPanelBtn.UseVisualStyleBackColor = false;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
            // 
            // kullaniciPanelBtn
            // 
            this.kullaniciPanelBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.kullaniciPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kullaniciPanelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kullaniciPanelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.kullaniciPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciPanelBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciPanelBtn.Image = ((System.Drawing.Image)(resources.GetObject("kullaniciPanelBtn.Image")));
            this.kullaniciPanelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kullaniciPanelBtn.Location = new System.Drawing.Point(303, 174);
            this.kullaniciPanelBtn.Name = "kullaniciPanelBtn";
            this.kullaniciPanelBtn.Size = new System.Drawing.Size(184, 186);
            this.kullaniciPanelBtn.TabIndex = 3;
            this.kullaniciPanelBtn.Text = "Kullanıcı Girişi";
            this.kullaniciPanelBtn.UseVisualStyleBackColor = false;
            this.kullaniciPanelBtn.Click += new System.EventHandler(this.kullaniciPanelBtn_Click);
            // 
            // egitmenPanelBtn
            // 
            this.egitmenPanelBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.egitmenPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.egitmenPanelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.egitmenPanelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.egitmenPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.egitmenPanelBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.egitmenPanelBtn.Image = ((System.Drawing.Image)(resources.GetObject("egitmenPanelBtn.Image")));
            this.egitmenPanelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.egitmenPanelBtn.Location = new System.Drawing.Point(590, 174);
            this.egitmenPanelBtn.Name = "egitmenPanelBtn";
            this.egitmenPanelBtn.Size = new System.Drawing.Size(184, 186);
            this.egitmenPanelBtn.TabIndex = 4;
            this.egitmenPanelBtn.Text = "Eğitmen Girişi";
            this.egitmenPanelBtn.UseVisualStyleBackColor = false;
            this.egitmenPanelBtn.Click += new System.EventHandler(this.egitmenPanelBtn_Click);
            // 
            // anaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(786, 512);
            this.Controls.Add(this.egitmenPanelBtn);
            this.Controls.Add(this.kullaniciPanelBtn);
            this.Controls.Add(this.adminPanelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anaSayfaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button adminPanelBtn;
        private System.Windows.Forms.Button kullaniciPanelBtn;
        private System.Windows.Forms.Button egitmenPanelBtn;
    }
}

