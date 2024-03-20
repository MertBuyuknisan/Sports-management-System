namespace sportDatabaseApp
{
    partial class KullanıcıPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sporBilgileri = new System.Windows.Forms.Button();
            this.KullanıcıPanelEgitmenBilgi = new System.Windows.Forms.Button();
            this.geriBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sporBilgileri
            // 
            this.sporBilgileri.BackColor = System.Drawing.Color.HotPink;
            this.sporBilgileri.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sporBilgileri.Location = new System.Drawing.Point(12, 12);
            this.sporBilgileri.Name = "sporBilgileri";
            this.sporBilgileri.Size = new System.Drawing.Size(114, 64);
            this.sporBilgileri.TabIndex = 0;
            this.sporBilgileri.Text = "Spor Bilgileri";
            this.sporBilgileri.UseVisualStyleBackColor = false;
            this.sporBilgileri.Click += new System.EventHandler(this.sporBilgileri_Click);
            // 
            // KullanıcıPanelEgitmenBilgi
            // 
            this.KullanıcıPanelEgitmenBilgi.BackColor = System.Drawing.Color.HotPink;
            this.KullanıcıPanelEgitmenBilgi.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıPanelEgitmenBilgi.Location = new System.Drawing.Point(12, 82);
            this.KullanıcıPanelEgitmenBilgi.Name = "KullanıcıPanelEgitmenBilgi";
            this.KullanıcıPanelEgitmenBilgi.Size = new System.Drawing.Size(114, 64);
            this.KullanıcıPanelEgitmenBilgi.TabIndex = 2;
            this.KullanıcıPanelEgitmenBilgi.Text = "Eğitmen Bilgileri";
            this.KullanıcıPanelEgitmenBilgi.UseVisualStyleBackColor = false;
            this.KullanıcıPanelEgitmenBilgi.Click += new System.EventHandler(this.KullanıcıPanelEgitmenBilgi_Click);
            // 
            // geriBtn
            // 
            this.geriBtn.BackColor = System.Drawing.Color.HotPink;
            this.geriBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.geriBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBtn.Location = new System.Drawing.Point(12, 152);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(114, 60);
            this.geriBtn.TabIndex = 3;
            this.geriBtn.Text = "Geri";
            this.geriBtn.UseVisualStyleBackColor = false;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // KullanıcıPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.KullanıcıPanelEgitmenBilgi);
            this.Controls.Add(this.sporBilgileri);
            this.Name = "KullanıcıPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullanıcıPaneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sporBilgileri;
        private System.Windows.Forms.Button KullanıcıPanelEgitmenBilgi;
        private System.Windows.Forms.Button geriBtn;
    }
}