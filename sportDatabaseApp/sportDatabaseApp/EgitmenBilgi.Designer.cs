namespace sportDatabaseApp
{
    partial class EgitmenBilgi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.geriBtn = new System.Windows.Forms.Button();
            this.yenileBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.egitmenAdAratxt = new System.Windows.Forms.TextBox();
            this.araBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(12, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // geriBtn
            // 
            this.geriBtn.BackColor = System.Drawing.Color.HotPink;
            this.geriBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.geriBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBtn.Location = new System.Drawing.Point(75, 225);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(141, 60);
            this.geriBtn.TabIndex = 1;
            this.geriBtn.Text = "Geri";
            this.geriBtn.UseVisualStyleBackColor = false;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // yenileBtn
            // 
            this.yenileBtn.BackColor = System.Drawing.Color.HotPink;
            this.yenileBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenileBtn.Location = new System.Drawing.Point(146, 165);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(137, 54);
            this.yenileBtn.TabIndex = 48;
            this.yenileBtn.Text = "Yenile";
            this.yenileBtn.UseVisualStyleBackColor = false;
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "Eğitmen Ara";
            // 
            // egitmenAdAratxt
            // 
            this.egitmenAdAratxt.Location = new System.Drawing.Point(12, 119);
            this.egitmenAdAratxt.Name = "egitmenAdAratxt";
            this.egitmenAdAratxt.Size = new System.Drawing.Size(262, 22);
            this.egitmenAdAratxt.TabIndex = 46;
            // 
            // araBtn
            // 
            this.araBtn.BackColor = System.Drawing.Color.HotPink;
            this.araBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araBtn.Location = new System.Drawing.Point(12, 165);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(128, 54);
            this.araBtn.TabIndex = 45;
            this.araBtn.Text = "Eğitmen Ara";
            this.araBtn.UseVisualStyleBackColor = false;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // EgitmenBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(985, 533);
            this.Controls.Add(this.yenileBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.egitmenAdAratxt);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EgitmenBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EgitmenBilgi";
            this.Load += new System.EventHandler(this.EgitmenBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.Button yenileBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox egitmenAdAratxt;
        private System.Windows.Forms.Button araBtn;
    }
}