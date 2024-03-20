namespace sportDatabaseApp
{
    partial class kullaniciGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciAdtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciSifretxt = new System.Windows.Forms.TextBox();
            this.kullaniciGirisBtn = new System.Windows.Forms.Button();
            this.geribtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Giriş Paneli";
            // 
            // kullaniciAdtxt
            // 
            this.kullaniciAdtxt.Location = new System.Drawing.Point(346, 165);
            this.kullaniciAdtxt.Name = "kullaniciAdtxt";
            this.kullaniciAdtxt.Size = new System.Drawing.Size(165, 22);
            this.kullaniciAdtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(167, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Şifre:";
            // 
            // kullaniciSifretxt
            // 
            this.kullaniciSifretxt.Location = new System.Drawing.Point(346, 233);
            this.kullaniciSifretxt.Name = "kullaniciSifretxt";
            this.kullaniciSifretxt.Size = new System.Drawing.Size(165, 22);
            this.kullaniciSifretxt.TabIndex = 4;
            this.kullaniciSifretxt.UseSystemPasswordChar = true;
            // 
            // kullaniciGirisBtn
            // 
            this.kullaniciGirisBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kullaniciGirisBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.kullaniciGirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullaniciGirisBtn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciGirisBtn.Location = new System.Drawing.Point(346, 280);
            this.kullaniciGirisBtn.Name = "kullaniciGirisBtn";
            this.kullaniciGirisBtn.Size = new System.Drawing.Size(163, 52);
            this.kullaniciGirisBtn.TabIndex = 6;
            this.kullaniciGirisBtn.Text = "Giriş";
            this.kullaniciGirisBtn.UseVisualStyleBackColor = true;
            this.kullaniciGirisBtn.Click += new System.EventHandler(this.kullaniciGirisBtn_Click);
            // 
            // geribtn
            // 
            this.geribtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.geribtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geribtn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geribtn.Location = new System.Drawing.Point(348, 338);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(163, 52);
            this.geribtn.TabIndex = 7;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = true;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // kullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.kullaniciGirisBtn);
            this.Controls.Add(this.kullaniciSifretxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullaniciAdtxt);
            this.Controls.Add(this.label1);
            this.Name = "kullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciAdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullaniciSifretxt;
        private System.Windows.Forms.Button kullaniciGirisBtn;
        private System.Windows.Forms.Button geribtn;
    }
}