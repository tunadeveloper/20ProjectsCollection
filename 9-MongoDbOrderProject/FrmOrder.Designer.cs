namespace _9_MongoDbOrderProject
{
	partial class FrmOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
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
            this.headerPanel.Size = new System.Drawing.Size(1000, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sipariş Yönetimi";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitle.Location = new System.Drawing.Point(26, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(241, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Kayıtları listeleyin, düzenleyin ve yönetin.";
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panelInputs.Controls.Add(this.txtTotalPrice);
            this.panelInputs.Controls.Add(this.lblTotalPrice);
            this.panelInputs.Controls.Add(this.txtCity);
            this.panelInputs.Controls.Add(this.lblCity);
            this.panelInputs.Controls.Add(this.txtDistrict);
            this.panelInputs.Controls.Add(this.lblDistrict);
            this.panelInputs.Controls.Add(this.txtCustomer);
            this.panelInputs.Controls.Add(this.lblCustomer);
            this.panelInputs.Controls.Add(this.txtOrderId);
            this.panelInputs.Controls.Add(this.lblOrderId);
            this.panelInputs.Location = new System.Drawing.Point(24, 96);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(360, 300);
            this.panelInputs.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalPrice.Location = new System.Drawing.Point(160, 240);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(176, 23);
            this.txtTotalPrice.TabIndex = 5;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalPrice.Location = new System.Drawing.Point(24, 243);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(74, 15);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Toplam Fiyat";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCity.Location = new System.Drawing.Point(160, 192);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(176, 23);
            this.txtCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCity.Location = new System.Drawing.Point(24, 195);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 15);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Şehir";
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistrict.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDistrict.Location = new System.Drawing.Point(160, 144);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(176, 23);
            this.txtDistrict.TabIndex = 3;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDistrict.Location = new System.Drawing.Point(24, 147);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(25, 15);
            this.lblDistrict.TabIndex = 4;
            this.lblDistrict.Text = "İlçe";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomer.Location = new System.Drawing.Point(160, 96);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(176, 23);
            this.txtCustomer.TabIndex = 2;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCustomer.Location = new System.Drawing.Point(24, 99);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(47, 15);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Müşteri";
            // 
            // txtOrderId
            // 
            this.txtOrderId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.txtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtOrderId.Location = new System.Drawing.Point(160, 48);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(176, 23);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOrderId.Location = new System.Drawing.Point(24, 51);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(54, 15);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Sipariş Id";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panelActions.Controls.Add(this.btnGetir);
            this.panelActions.Controls.Add(this.btnGuncelle);
            this.panelActions.Controls.Add(this.btnSil);
            this.panelActions.Controls.Add(this.btnEkle);
            this.panelActions.Controls.Add(this.btnListele);
            this.panelActions.Location = new System.Drawing.Point(24, 408);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(952, 72);
            this.panelActions.TabIndex = 2;
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            this.btnGetir.FlatAppearance.BorderSize = 0;
            this.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGetir.ForeColor = System.Drawing.Color.White;
            this.btnGetir.Location = new System.Drawing.Point(760, 16);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(168, 40);
            this.btnGetir.TabIndex = 10;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(576, 16);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(168, 40);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(392, 16);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(168, 40);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(208, 16);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(168, 40);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.btnListele.FlatAppearance.BorderSize = 0;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(24, 16);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(168, 40);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panelGrid.Controls.Add(this.dgvOrders);
            this.panelGrid.Location = new System.Drawing.Point(400, 96);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(576, 300);
            this.panelGrid.TabIndex = 3;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOrders.ColumnHeadersHeight = 36;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(114)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(576, 300);
            this.dgvOrders.TabIndex = 0;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MongoDB Sipariş Yönetimi";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSubtitle;
		private System.Windows.Forms.Panel panelInputs;
		private System.Windows.Forms.TextBox txtOrderId;
		private System.Windows.Forms.Label lblOrderId;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.Label lblCustomer;
		private System.Windows.Forms.TextBox txtDistrict;
		private System.Windows.Forms.Label lblDistrict;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label lblTotalPrice;
		private System.Windows.Forms.Panel panelActions;
		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnGetir;
		private System.Windows.Forms.Panel panelGrid;
		private System.Windows.Forms.DataGridView dgvOrders;
	}
}