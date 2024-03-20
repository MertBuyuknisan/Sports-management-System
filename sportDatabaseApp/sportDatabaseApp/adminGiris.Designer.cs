namespace sportDatabaseApp
{
    partial class adminGiris
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminkAdtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminSifretxt = new System.Windows.Forms.TextBox();
            this.adminGirisBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.label1.Size = new System.Drawing.Size(449, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMİN GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // adminkAdtxt
            // 
            this.adminkAdtxt.Location = new System.Drawing.Point(322, 165);
            this.adminkAdtxt.Name = "adminkAdtxt";
            this.adminkAdtxt.Size = new System.Drawing.Size(165, 22);
            this.adminkAdtxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(170, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Admin Şifre:";
            // 
            // adminSifretxt
            // 
            this.adminSifretxt.Location = new System.Drawing.Point(322, 233);
            this.adminSifretxt.Name = "adminSifretxt";
            this.adminSifretxt.Size = new System.Drawing.Size(165, 22);
            this.adminSifretxt.TabIndex = 4;
            this.adminSifretxt.UseSystemPasswordChar = true;
            // 
            // adminGirisBtn
            // 
            this.adminGirisBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminGirisBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminGirisBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.adminGirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminGirisBtn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGirisBtn.Location = new System.Drawing.Point(322, 299);
            this.adminGirisBtn.Name = "adminGirisBtn";
            this.adminGirisBtn.Size = new System.Drawing.Size(163, 52);
            this.adminGirisBtn.TabIndex = 5;
            this.adminGirisBtn.Text = "Giriş";
            this.adminGirisBtn.UseVisualStyleBackColor = true;
            this.adminGirisBtn.Click += new System.EventHandler(this.adminGirisBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // geribtn
            // 
            this.geribtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.geribtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geribtn.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geribtn.Location = new System.Drawing.Point(322, 357);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(163, 52);
            this.geribtn.TabIndex = 6;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = true;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // adminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.adminGirisBtn);
            this.Controls.Add(this.adminSifretxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminkAdtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminkAdtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminSifretxt;
        private System.Windows.Forms.Button adminGirisBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button geribtn;
    }
}