namespace _8_RapidAPICurrencyProject
{
	partial class FrmCurrency
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelRates = new System.Windows.Forms.Panel();
            this.iconPound = new System.Windows.Forms.Label();
            this.iconEuro = new System.Windows.Forms.Label();
            this.iconDollar = new System.Windows.Forms.Label();
            this.lblPound = new System.Windows.Forms.Label();
            this.lblPoundTitle = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblEuroTitle = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblDollarTitle = new System.Windows.Forms.Label();
            this.panelAction = new System.Windows.Forms.Panel();
            this.radioPound = new System.Windows.Forms.RadioButton();
            this.radioEuro = new System.Windows.Forms.RadioButton();
            this.radioDolar = new System.Windows.Forms.RadioButton();
            this.txtTotalAmound = new System.Windows.Forms.MaskedTextBox();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.txtUnitAmount = new System.Windows.Forms.MaskedTextBox();
            this.lblBirimTutar = new System.Windows.Forms.Label();
            this.btnIslemiYap = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panelRates.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(720, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Döviz Dönüşüm Paneli";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitle.Location = new System.Drawing.Point(26, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(339, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Anlık kurları görüntüleyin, tutar girin ve hızlıca hesaplayın.";
            // 
            // panelRates
            // 
            this.panelRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panelRates.Controls.Add(this.iconPound);
            this.panelRates.Controls.Add(this.iconEuro);
            this.panelRates.Controls.Add(this.iconDollar);
            this.panelRates.Controls.Add(this.lblPound);
            this.panelRates.Controls.Add(this.lblPoundTitle);
            this.panelRates.Controls.Add(this.lblEuro);
            this.panelRates.Controls.Add(this.lblEuroTitle);
            this.panelRates.Controls.Add(this.lblDollar);
            this.panelRates.Controls.Add(this.lblDollarTitle);
            this.panelRates.Location = new System.Drawing.Point(24, 96);
            this.panelRates.Name = "panelRates";
            this.panelRates.Size = new System.Drawing.Size(672, 120);
            this.panelRates.TabIndex = 1;
            // 
            // iconPound
            // 
            this.iconPound.AutoSize = true;
            this.iconPound.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.iconPound.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPound.Location = new System.Drawing.Point(535, 17);
            this.iconPound.Name = "iconPound";
            this.iconPound.Size = new System.Drawing.Size(38, 26);
            this.iconPound.TabIndex = 24;
            this.iconPound.Text = "💷";
            // 
            // iconEuro
            // 
            this.iconEuro.AutoSize = true;
            this.iconEuro.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.iconEuro.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconEuro.Location = new System.Drawing.Point(311, 17);
            this.iconEuro.Name = "iconEuro";
            this.iconEuro.Size = new System.Drawing.Size(38, 26);
            this.iconEuro.TabIndex = 23;
            this.iconEuro.Text = "💶";
            // 
            // iconDollar
            // 
            this.iconDollar.AutoSize = true;
            this.iconDollar.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.iconDollar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconDollar.Location = new System.Drawing.Point(89, 17);
            this.iconDollar.Name = "iconDollar";
            this.iconDollar.Size = new System.Drawing.Size(38, 26);
            this.iconDollar.TabIndex = 22;
            this.iconDollar.Text = "💵";
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblPound.Location = new System.Drawing.Point(524, 84);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(60, 19);
            this.lblPound.TabIndex = 21;
            this.lblPound.Text = "00,0000";
            // 
            // lblPoundTitle
            // 
            this.lblPoundTitle.AutoSize = true;
            this.lblPoundTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPoundTitle.Location = new System.Drawing.Point(535, 51);
            this.lblPoundTitle.Name = "lblPoundTitle";
            this.lblPoundTitle.Size = new System.Drawing.Size(47, 19);
            this.lblPoundTitle.TabIndex = 20;
            this.lblPoundTitle.Text = "Sterlin";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblEuro.Location = new System.Drawing.Point(300, 84);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(60, 19);
            this.lblEuro.TabIndex = 19;
            this.lblEuro.Text = "00,0000";
            // 
            // lblEuroTitle
            // 
            this.lblEuroTitle.AutoSize = true;
            this.lblEuroTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEuroTitle.Location = new System.Drawing.Point(311, 51);
            this.lblEuroTitle.Name = "lblEuroTitle";
            this.lblEuroTitle.Size = new System.Drawing.Size(37, 19);
            this.lblEuroTitle.TabIndex = 18;
            this.lblEuroTitle.Text = "Euro";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblDollar.Location = new System.Drawing.Point(78, 84);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(60, 19);
            this.lblDollar.TabIndex = 17;
            this.lblDollar.Text = "00,0000";
            // 
            // lblDollarTitle
            // 
            this.lblDollarTitle.AutoSize = true;
            this.lblDollarTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDollarTitle.Location = new System.Drawing.Point(89, 51);
            this.lblDollarTitle.Name = "lblDollarTitle";
            this.lblDollarTitle.Size = new System.Drawing.Size(42, 19);
            this.lblDollarTitle.TabIndex = 16;
            this.lblDollarTitle.Text = "Dolar";
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panelAction.Controls.Add(this.radioPound);
            this.panelAction.Controls.Add(this.radioEuro);
            this.panelAction.Controls.Add(this.radioDolar);
            this.panelAction.Controls.Add(this.txtTotalAmound);
            this.panelAction.Controls.Add(this.lblOdenecekTutar);
            this.panelAction.Controls.Add(this.txtUnitAmount);
            this.panelAction.Controls.Add(this.lblBirimTutar);
            this.panelAction.Controls.Add(this.btnIslemiYap);
            this.panelAction.Location = new System.Drawing.Point(24, 232);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(672, 176);
            this.panelAction.TabIndex = 2;
            // 
            // radioPound
            // 
            this.radioPound.AutoSize = true;
            this.radioPound.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioPound.Location = new System.Drawing.Point(298, 20);
            this.radioPound.Name = "radioPound";
            this.radioPound.Size = new System.Drawing.Size(65, 23);
            this.radioPound.TabIndex = 3;
            this.radioPound.TabStop = true;
            this.radioPound.Text = "Sterlin";
            this.radioPound.UseVisualStyleBackColor = true;
            // 
            // radioEuro
            // 
            this.radioEuro.AutoSize = true;
            this.radioEuro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioEuro.Location = new System.Drawing.Point(230, 20);
            this.radioEuro.Name = "radioEuro";
            this.radioEuro.Size = new System.Drawing.Size(55, 23);
            this.radioEuro.TabIndex = 2;
            this.radioEuro.TabStop = true;
            this.radioEuro.Text = "Euro";
            this.radioEuro.UseVisualStyleBackColor = true;
            // 
            // radioDolar
            // 
            this.radioDolar.AutoSize = true;
            this.radioDolar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioDolar.Location = new System.Drawing.Point(160, 20);
            this.radioDolar.Name = "radioDolar";
            this.radioDolar.Size = new System.Drawing.Size(60, 23);
            this.radioDolar.TabIndex = 1;
            this.radioDolar.TabStop = true;
            this.radioDolar.Text = "Dolar";
            this.radioDolar.UseVisualStyleBackColor = true;
            // 
            // txtTotalAmound
            // 
            this.txtTotalAmound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.txtTotalAmound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmound.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalAmound.Location = new System.Drawing.Point(160, 96);
            this.txtTotalAmound.Name = "txtTotalAmound";
            this.txtTotalAmound.Size = new System.Drawing.Size(240, 25);
            this.txtTotalAmound.TabIndex = 5;
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOdenecekTutar.Location = new System.Drawing.Point(26, 99);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(106, 19);
            this.lblOdenecekTutar.TabIndex = 6;
            this.lblOdenecekTutar.Text = "Ödenecek Tutar";
            // 
            // txtUnitAmount
            // 
            this.txtUnitAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.txtUnitAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitAmount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnitAmount.Location = new System.Drawing.Point(160, 60);
            this.txtUnitAmount.Name = "txtUnitAmount";
            this.txtUnitAmount.Size = new System.Drawing.Size(240, 25);
            this.txtUnitAmount.TabIndex = 4;
            // 
            // lblBirimTutar
            // 
            this.lblBirimTutar.AutoSize = true;
            this.lblBirimTutar.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBirimTutar.Location = new System.Drawing.Point(26, 63);
            this.lblBirimTutar.Name = "lblBirimTutar";
            this.lblBirimTutar.Size = new System.Drawing.Size(76, 19);
            this.lblBirimTutar.TabIndex = 3;
            this.lblBirimTutar.Text = "Birim Tutar";
            // 
            // btnIslemiYap
            // 
            this.btnIslemiYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnIslemiYap.FlatAppearance.BorderSize = 0;
            this.btnIslemiYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemiYap.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnIslemiYap.ForeColor = System.Drawing.Color.White;
            this.btnIslemiYap.Location = new System.Drawing.Point(424, 60);
            this.btnIslemiYap.Name = "btnIslemiYap";
            this.btnIslemiYap.Size = new System.Drawing.Size(208, 61);
            this.btnIslemiYap.TabIndex = 6;
            this.btnIslemiYap.Text = "Hesapla";
            this.btnIslemiYap.UseVisualStyleBackColor = false;
            this.btnIslemiYap.Click += new System.EventHandler(this.btnIslemiYap_Click);
            // 
            // FrmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(720, 440);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelRates);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panelRates.ResumeLayout(false);
            this.panelRates.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.Panel panelRates;
		private System.Windows.Forms.Label iconPound;
		private System.Windows.Forms.Label iconEuro;
		private System.Windows.Forms.Label iconDollar;
		private System.Windows.Forms.Label lblDollarTitle;
		private System.Windows.Forms.Label lblEuroTitle;
		private System.Windows.Forms.Label lblDollar;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.Label lblPound;
		private System.Windows.Forms.Label lblPoundTitle;
		private System.Windows.Forms.Panel panelAction;
		private System.Windows.Forms.RadioButton radioDolar;
		private System.Windows.Forms.RadioButton radioEuro;
		private System.Windows.Forms.RadioButton radioPound;
		private System.Windows.Forms.Label lblBirimTutar;
		private System.Windows.Forms.MaskedTextBox txtUnitAmount;
		private System.Windows.Forms.Label lblOdenecekTutar;
		private System.Windows.Forms.MaskedTextBox txtTotalAmound;
		private System.Windows.Forms.Button btnIslemiYap;
	}
}