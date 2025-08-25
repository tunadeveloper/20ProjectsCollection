namespace _1_AdoNetCustomerProject
{
    partial class FrmMap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustomerOps = new System.Windows.Forms.Button();
            this.btnCityOps = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblSubtitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 120);
            this.panel1.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSubtitle.Location = new System.Drawing.Point(41, 79);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(409, 21);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Hızlı erişim: şehir ve müşteri işlemleri ile oturum yönetimi";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(39, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🧭 Uygulama Haritası";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelButtons.Controls.Add(this.btnExit);
            this.panelButtons.Controls.Add(this.btnCustomerOps);
            this.panelButtons.Controls.Add(this.btnCityOps);
            this.panelButtons.Location = new System.Drawing.Point(72, 162);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(350, 260);
            this.panelButtons.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(25, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "🚪 Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCustomerOps
            // 
            this.btnCustomerOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCustomerOps.FlatAppearance.BorderSize = 0;
            this.btnCustomerOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerOps.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCustomerOps.ForeColor = System.Drawing.Color.White;
            this.btnCustomerOps.Location = new System.Drawing.Point(25, 120);
            this.btnCustomerOps.Name = "btnCustomerOps";
            this.btnCustomerOps.Size = new System.Drawing.Size(300, 50);
            this.btnCustomerOps.TabIndex = 1;
            this.btnCustomerOps.Text = "👥 Müşteri İşlemleri";
            this.btnCustomerOps.UseVisualStyleBackColor = false;
            this.btnCustomerOps.Click += new System.EventHandler(this.btnCustomerOps_Click);
            // 
            // btnCityOps
            // 
            this.btnCityOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCityOps.FlatAppearance.BorderSize = 0;
            this.btnCityOps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCityOps.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCityOps.ForeColor = System.Drawing.Color.White;
            this.btnCityOps.Location = new System.Drawing.Point(25, 60);
            this.btnCityOps.Name = "btnCityOps";
            this.btnCityOps.Size = new System.Drawing.Size(300, 50);
            this.btnCityOps.TabIndex = 0;
            this.btnCityOps.Text = "🏙️ Şehir İşlemleri";
            this.btnCityOps.UseVisualStyleBackColor = false;
            this.btnCityOps.Click += new System.EventHandler(this.btnCityOps_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(503, 503);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🧭 Uygulama Haritası";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnCityOps;
        private System.Windows.Forms.Button btnCustomerOps;
        private System.Windows.Forms.Button btnExit;
    }
}