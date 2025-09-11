namespace _12_JSONWebTokenProject
{
    partial class FrmTokenGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGenerateToken;
        private System.Windows.Forms.RichTextBox rtbToken;

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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGenerateToken = new System.Windows.Forms.Button();
            this.rtbToken = new System.Windows.Forms.RichTextBox();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Token Oluşturma";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.pnlCard.Controls.Add(this.lblUsername);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblFirstName);
            this.pnlCard.Controls.Add(this.txtFirstName);
            this.pnlCard.Controls.Add(this.lblLastName);
            this.pnlCard.Controls.Add(this.txtLastName);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.btnGenerateToken);
            this.pnlCard.Location = new System.Drawing.Point(28, 56);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlCard.Size = new System.Drawing.Size(724, 206);
            this.pnlCard.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(24, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Kullanıcı Adı";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Location = new System.Drawing.Point(136, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFirstName.Location = new System.Drawing.Point(24, 74);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Adı";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(136, 70);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 25);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLastName.Location = new System.Drawing.Point(24, 122);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(49, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Soyadı";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(136, 118);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(220, 25);
            this.txtLastName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(388, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-Posta Adresi";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(504, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // btnGenerateToken
            // 
            this.btnGenerateToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnGenerateToken.FlatAppearance.BorderSize = 0;
            this.btnGenerateToken.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            this.btnGenerateToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnGenerateToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateToken.ForeColor = System.Drawing.Color.White;
            this.btnGenerateToken.Location = new System.Drawing.Point(392, 114);
            this.btnGenerateToken.Name = "btnGenerateToken";
            this.btnGenerateToken.Size = new System.Drawing.Size(312, 36);
            this.btnGenerateToken.TabIndex = 8;
            this.btnGenerateToken.Text = "Token Oluştur";
            this.btnGenerateToken.UseVisualStyleBackColor = false;
            this.btnGenerateToken.Click += new System.EventHandler(this.btnGenerateToken_Click);
            // 
            // rtbToken
            // 
            this.rtbToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.rtbToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbToken.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbToken.Location = new System.Drawing.Point(28, 278);
            this.rtbToken.Name = "rtbToken";
            this.rtbToken.ReadOnly = true;
            this.rtbToken.Size = new System.Drawing.Size(724, 214);
            this.rtbToken.TabIndex = 9;
            this.rtbToken.Text = "";
            // 
            // FrmTokenGenerator
            // 
            this.AcceptButton = this.btnGenerateToken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.rtbToken);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTokenGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Oluşturma";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}