namespace _16_MailRegisterProject
{
    partial class FrmRegister
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pnlLastNameShadow = new System.Windows.Forms.Panel();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlEmailShadow = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlPasswordShadow = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.pnlConfirmShadow = new System.Windows.Forms.Panel();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlFirstNameShadow = new System.Windows.Forms.Panel();
            this.pnlFirstName.SuspendLayout();
            this.pnlLastName.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(63)))), ((int)(((byte)(155)))));
            this.lblTitle.Location = new System.Drawing.Point(60, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hesap Oluşturun";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblFirstName.Location = new System.Drawing.Point(64, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(49, 19);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Adınız";
            // 
            // pnlFirstName
            // 
            this.pnlFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlFirstName.Controls.Add(this.txtFirstName);
            this.pnlFirstName.Location = new System.Drawing.Point(64, 141);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlFirstName.Size = new System.Drawing.Size(360, 46);
            this.pnlFirstName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtFirstName.Location = new System.Drawing.Point(16, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(328, 19);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblLastName.Location = new System.Drawing.Point(64, 200);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 19);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Soyadınız";
            // 
            // pnlLastNameShadow
            // 
            this.pnlLastNameShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.pnlLastNameShadow.Enabled = false;
            this.pnlLastNameShadow.Location = new System.Drawing.Point(68, 225);
            this.pnlLastNameShadow.Name = "pnlLastNameShadow";
            this.pnlLastNameShadow.Size = new System.Drawing.Size(360, 46);
            this.pnlLastNameShadow.TabIndex = 8;
            // 
            // pnlLastName
            // 
            this.pnlLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlLastName.Controls.Add(this.txtLastName);
            this.pnlLastName.Location = new System.Drawing.Point(64, 221);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlLastName.Size = new System.Drawing.Size(360, 46);
            this.pnlLastName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtLastName.Location = new System.Drawing.Point(16, 13);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(328, 19);
            this.txtLastName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(64, 280);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(99, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-Posta Adresi";
            // 
            // pnlEmailShadow
            // 
            this.pnlEmailShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.pnlEmailShadow.Enabled = false;
            this.pnlEmailShadow.Location = new System.Drawing.Point(68, 305);
            this.pnlEmailShadow.Name = "pnlEmailShadow";
            this.pnlEmailShadow.Size = new System.Drawing.Size(360, 46);
            this.pnlEmailShadow.TabIndex = 10;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(64, 301);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlEmail.Size = new System.Drawing.Size(360, 46);
            this.pnlEmail.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtEmail.Location = new System.Drawing.Point(16, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 19);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblPassword.Location = new System.Drawing.Point(64, 360);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Şifre";
            // 
            // pnlPasswordShadow
            // 
            this.pnlPasswordShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.pnlPasswordShadow.Enabled = false;
            this.pnlPasswordShadow.Location = new System.Drawing.Point(68, 385);
            this.pnlPasswordShadow.Name = "pnlPasswordShadow";
            this.pnlPasswordShadow.Size = new System.Drawing.Size(360, 46);
            this.pnlPasswordShadow.TabIndex = 12;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(64, 381);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlPassword.Size = new System.Drawing.Size(360, 46);
            this.pnlPassword.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtPassword.Location = new System.Drawing.Point(16, 13);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(328, 19);
            this.txtPassword.TabIndex = 3;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblConfirm.Location = new System.Drawing.Point(64, 440);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(80, 19);
            this.lblConfirm.TabIndex = 5;
            this.lblConfirm.Text = "Şifre Tekrar";
            // 
            // pnlConfirmShadow
            // 
            this.pnlConfirmShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.pnlConfirmShadow.Enabled = false;
            this.pnlConfirmShadow.Location = new System.Drawing.Point(68, 465);
            this.pnlConfirmShadow.Name = "pnlConfirmShadow";
            this.pnlConfirmShadow.Size = new System.Drawing.Size(360, 46);
            this.pnlConfirmShadow.TabIndex = 14;
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlConfirm.Controls.Add(this.txtConfirm);
            this.pnlConfirm.Location = new System.Drawing.Point(64, 461);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlConfirm.Size = new System.Drawing.Size(360, 46);
            this.pnlConfirm.TabIndex = 15;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtConfirm.Location = new System.Drawing.Point(16, 13);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '•';
            this.txtConfirm.Size = new System.Drawing.Size(328, 19);
            this.txtConfirm.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(86)))), ((int)(((byte)(206)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(72)))), ((int)(((byte)(173)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(103)))), ((int)(((byte)(220)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(64, 540);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(360, 54);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlFirstNameShadow
            // 
            this.pnlFirstNameShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.pnlFirstNameShadow.Enabled = false;
            this.pnlFirstNameShadow.Location = new System.Drawing.Point(68, 145);
            this.pnlFirstNameShadow.Name = "pnlFirstNameShadow";
            this.pnlFirstNameShadow.Size = new System.Drawing.Size(360, 46);
            this.pnlFirstNameShadow.TabIndex = 6;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 640);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.pnlFirstNameShadow);
            this.Controls.Add(this.pnlFirstName);
            this.Controls.Add(this.pnlLastNameShadow);
            this.Controls.Add(this.pnlLastName);
            this.Controls.Add(this.pnlEmailShadow);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlPasswordShadow);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlConfirmShadow);
            this.Controls.Add(this.pnlConfirm);
            this.Controls.Add(this.btnRegister);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Formu";
            // Ensure shadow panels don't block input and stay behind
            this.pnlFirstNameShadow.Enabled = false;
            this.pnlFirstNameShadow.TabStop = false;
            this.pnlFirstNameShadow.Visible = false;
            this.pnlFirstName.BringToFront();
            this.pnlFirstNameShadow.SendToBack();
            this.pnlLastNameShadow.Enabled = false;
            this.pnlLastNameShadow.TabStop = false;
            this.pnlLastNameShadow.Visible = false;
            this.pnlLastName.BringToFront();
            this.pnlLastNameShadow.SendToBack();
            this.pnlEmailShadow.Enabled = false;
            this.pnlEmailShadow.TabStop = false;
            this.pnlEmailShadow.Visible = false;
            this.pnlEmail.BringToFront();
            this.pnlEmailShadow.SendToBack();
            this.pnlPasswordShadow.Enabled = false;
            this.pnlPasswordShadow.TabStop = false;
            this.pnlPasswordShadow.Visible = false;
            this.pnlPassword.BringToFront();
            this.pnlPasswordShadow.SendToBack();
            this.pnlConfirmShadow.Enabled = false;
            this.pnlConfirmShadow.TabStop = false;
            this.pnlConfirmShadow.Visible = false;
            this.pnlConfirm.BringToFront();
            this.pnlConfirmShadow.SendToBack();
            this.pnlFirstName.ResumeLayout(false);
            this.pnlFirstName.PerformLayout();
            this.pnlLastName.ResumeLayout(false);
            this.pnlLastName.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlConfirm.ResumeLayout(false);
            this.pnlConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel pnlLastNameShadow;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlEmailShadow;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlPasswordShadow;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Panel pnlConfirmShadow;
        private System.Windows.Forms.Panel pnlConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlFirstNameShadow;
    }
}

