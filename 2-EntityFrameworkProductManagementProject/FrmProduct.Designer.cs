namespace _2_EntityFrameworkProductManagementProject
{
    partial class FrmProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.cboProductCategory = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 120);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.lblSubtitle.Location = new System.Drawing.Point(32, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(305, 21);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Ürünleri yönetin, arayın ve hızlıca listeleyin";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "📦 Ürün Yönetimi";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.pnlTop.Controls.Add(this.txtProductPrice);
            this.pnlTop.Controls.Add(this.lblProductPrice);
            this.pnlTop.Controls.Add(this.txtProductStock);
            this.pnlTop.Controls.Add(this.lblProductStock);
            this.pnlTop.Controls.Add(this.txtProductName);
            this.pnlTop.Controls.Add(this.lblProductName);
            this.pnlTop.Controls.Add(this.txtProductId);
            this.pnlTop.Controls.Add(this.lblProductId);
            this.pnlTop.Controls.Add(this.cboProductCategory);
            this.pnlTop.Controls.Add(this.lblProductCategory);
            this.pnlTop.Location = new System.Drawing.Point(30, 150);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(16);
            this.pnlTop.Size = new System.Drawing.Size(360, 333);
            this.pnlTop.TabIndex = 2;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductPrice.ForeColor = System.Drawing.Color.White;
            this.txtProductPrice.Location = new System.Drawing.Point(25, 223);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(300, 22);
            this.txtProductPrice.TabIndex = 0;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(64)))));
            this.lblProductPrice.Location = new System.Drawing.Point(25, 198);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(108, 20);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "💲 Ürün Fiyat";
            // 
            // txtProductStock
            // 
            this.txtProductStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtProductStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductStock.ForeColor = System.Drawing.Color.White;
            this.txtProductStock.Location = new System.Drawing.Point(25, 163);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(300, 22);
            this.txtProductStock.TabIndex = 2;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(64)))));
            this.lblProductStock.Location = new System.Drawing.Point(25, 138);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(105, 20);
            this.lblProductStock.TabIndex = 3;
            this.lblProductStock.Text = "📦 Ürün Stok";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductName.ForeColor = System.Drawing.Color.White;
            this.txtProductName.Location = new System.Drawing.Point(25, 103);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(300, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(64)))));
            this.lblProductName.Location = new System.Drawing.Point(25, 78);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 20);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "🏷️ Ürün Adı";
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductId.ForeColor = System.Drawing.Color.White;
            this.txtProductId.Location = new System.Drawing.Point(25, 43);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(300, 22);
            this.txtProductId.TabIndex = 6;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(64)))));
            this.lblProductId.Location = new System.Drawing.Point(25, 18);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(90, 20);
            this.lblProductId.TabIndex = 7;
            this.lblProductId.Text = "🔖 Ürün ID";
            // 
            // cboProductCategory
            // 
            this.cboProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboProductCategory.ForeColor = System.Drawing.Color.White;
            this.cboProductCategory.Location = new System.Drawing.Point(25, 283);
            this.cboProductCategory.Name = "cboProductCategory";
            this.cboProductCategory.Size = new System.Drawing.Size(300, 28);
            this.cboProductCategory.TabIndex = 8;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(64)))));
            this.lblProductCategory.Location = new System.Drawing.Point(25, 258);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(134, 20);
            this.lblProductCategory.TabIndex = 9;
            this.lblProductCategory.Text = "🧩 Ürün Kategori";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.pnlActions.Controls.Add(this.btnSearch);
            this.pnlActions.Controls.Add(this.btnList);
            this.pnlActions.Controls.Add(this.btnUpdate);
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnAdd);
            this.pnlActions.Location = new System.Drawing.Point(30, 489);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(360, 321);
            this.pnlActions.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(25, 259);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(310, 50);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "🔍 Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(25, 19);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(310, 50);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "📋 Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(71)))), ((int)(((byte)(188)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(25, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(310, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "✏️ Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(25, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(310, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "🗑️ Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(310, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "➕ Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvProducts.ColumnHeadersHeight = 38;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvProducts.Location = new System.Drawing.Point(420, 150);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 35;
            this.dgvProducts.Size = new System.Drawing.Size(750, 660);
            this.dgvProducts.TabIndex = 0;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1200, 854);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📦 Ürün Yönetim Sistemi";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox cboProductCategory;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}