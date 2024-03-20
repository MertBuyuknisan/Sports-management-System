namespace sportDatabaseApp
{
    partial class egitmenGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.egitmenSifretxt = new System.Windows.Forms.TextBox();
            this.egitmenkAdtxt = new System.Windows.Forms.TextBox();
            this.egitmenGirisBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.geribtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eğitmen Şifre:";
            // 
            // egitmenSifretxt
            // 
            this.egitmenSifretxt.Location = new System.Drawing.Point(298, 209);
            this.egitmenSifretxt.Name = "egitmenSifretxt";
            this.egitmenSifretxt.Size = new System.Drawing.Size(165, 22);
            this.egitmenSifretxt.TabIndex = 4;
            this.egitmenSifretxt.UseSystemPasswordChar = true;
            // 
            // egitmenkAdtxt
            // 
            this.egitmenkAdtxt.Location = new System.Drawing.Point(298, 145);
            this.egitmenkAdtxt.Name = "egitmenkAdtxt";
            this.egitmenkAdtxt.Size = new System.Drawing.Size(165, 22);
            this.egitmenkAdtxt.TabIndex = 5;
            // 
            // egitmenGirisBtn
            // 
            this.egitmenGirisBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.egitmenGirisBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.egitmenGirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.egitmenGirisBtn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.egitmenGirisBtn.Location = new System.Drawing.Point(298, 255);
            this.egitmenGirisBtn.Name = "egitmenGirisBtn";
            this.egitmenGirisBtn.Size = new System.Drawing.Size(163, 52);
            this.egitmenGirisBtn.TabIndex = 6;
            this.egitmenGirisBtn.Text = "Giriş";
            this.egitmenGirisBtn.UseVisualStyleBackColor = true;
            this.egitmenGirisBtn.Click += new System.EventHandler(this.egitmenGirisBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(150, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "EĞİTMEN GİRİŞ PANELİ";
            // 
            // geribtn
            // 
            this.geribtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.geribtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geribtn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geribtn.Location = new System.Drawing.Point(298, 313);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(163, 52);
            this.geribtn.TabIndex = 8;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = true;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // egitmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(787, 438);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.egitmenGirisBtn);
            this.Controls.Add(this.egitmenkAdtxt);
            this.Controls.Add(this.egitmenSifretxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(183, 42);
            this.Name = "egitmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "egitmenGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox egitmenSifretxt;
        private System.Windows.Forms.TextBox egitmenkAdtxt;
        private System.Windows.Forms.Button egitmenGirisBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button geribtn;
    }
}