namespace _15_RapidAPIGasPriceSimulationProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelFuelAmount;
        private System.Windows.Forms.TextBox txtFuelAmount;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label labelLiveFill;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupPrices;
        private System.Windows.Forms.Label labelBenzin;
        private System.Windows.Forms.Label labelMotorin;
        private System.Windows.Forms.Label labelLpg;
        private System.Windows.Forms.TextBox txtGasolinePrice;
        private System.Windows.Forms.TextBox txtDieselPrice;
        private System.Windows.Forms.TextBox txtLpgPrice;
        private System.Windows.Forms.GroupBox groupFuelType;
        private System.Windows.Forms.RadioButton rdbGasoline;
        private System.Windows.Forms.RadioButton rdbDiesel;
        private System.Windows.Forms.RadioButton rdbLpg;

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
            this.labelFuelAmount = new System.Windows.Forms.Label();
            this.txtFuelAmount = new System.Windows.Forms.TextBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.labelLiveFill = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupPrices = new System.Windows.Forms.GroupBox();
            this.labelBenzin = new System.Windows.Forms.Label();
            this.txtGasolinePrice = new System.Windows.Forms.TextBox();
            this.labelMotorin = new System.Windows.Forms.Label();
            this.txtDieselPrice = new System.Windows.Forms.TextBox();
            this.labelLpg = new System.Windows.Forms.Label();
            this.txtLpgPrice = new System.Windows.Forms.TextBox();
            this.groupFuelType = new System.Windows.Forms.GroupBox();
            this.rdbGasoline = new System.Windows.Forms.RadioButton();
            this.rdbDiesel = new System.Windows.Forms.RadioButton();
            this.rdbLpg = new System.Windows.Forms.RadioButton();
            this.groupPrices.SuspendLayout();
            this.groupFuelType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFuelAmount
            // 
            this.labelFuelAmount.AutoSize = true;
            this.labelFuelAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFuelAmount.ForeColor = System.Drawing.Color.White;
            this.labelFuelAmount.Location = new System.Drawing.Point(42, 130);
            this.labelFuelAmount.Name = "labelFuelAmount";
            this.labelFuelAmount.Size = new System.Drawing.Size(85, 19);
            this.labelFuelAmount.TabIndex = 0;
            this.labelFuelAmount.Text = "Yakıt Miktarı";
            // 
            // txtFuelAmount
            // 
            this.txtFuelAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFuelAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuelAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFuelAmount.ForeColor = System.Drawing.Color.White;
            this.txtFuelAmount.Location = new System.Drawing.Point(252, 126);
            this.txtFuelAmount.Name = "txtFuelAmount";
            this.txtFuelAmount.Size = new System.Drawing.Size(260, 25);
            this.txtFuelAmount.TabIndex = 1;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTotalCost.ForeColor = System.Drawing.Color.White;
            this.labelTotalCost.Location = new System.Drawing.Point(42, 180);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(89, 19);
            this.labelTotalCost.TabIndex = 2;
            this.labelTotalCost.Text = "Toplam Tutar";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(252, 176);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(260, 25);
            this.txtTotalPrice.TabIndex = 3;
            // 
            // labelLiveFill
            // 
            this.labelLiveFill.AutoSize = true;
            this.labelLiveFill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLiveFill.ForeColor = System.Drawing.Color.White;
            this.labelLiveFill.Location = new System.Drawing.Point(42, 230);
            this.labelLiveFill.Name = "labelLiveFill";
            this.labelLiveFill.Size = new System.Drawing.Size(139, 19);
            this.labelLiveFill.TabIndex = 4;
            this.labelLiveFill.Text = "Anlık Dolum Durumu";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.progressBar1.Location = new System.Drawing.Point(252, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(252, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "İşlemi Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupPrices
            // 
            this.groupPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.groupPrices.Controls.Add(this.labelBenzin);
            this.groupPrices.Controls.Add(this.txtGasolinePrice);
            this.groupPrices.Controls.Add(this.labelMotorin);
            this.groupPrices.Controls.Add(this.txtDieselPrice);
            this.groupPrices.Controls.Add(this.labelLpg);
            this.groupPrices.Controls.Add(this.txtLpgPrice);
            this.groupPrices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupPrices.ForeColor = System.Drawing.Color.White;
            this.groupPrices.Location = new System.Drawing.Point(527, 21);
            this.groupPrices.Name = "groupPrices";
            this.groupPrices.Padding = new System.Windows.Forms.Padding(10);
            this.groupPrices.Size = new System.Drawing.Size(300, 180);
            this.groupPrices.TabIndex = 7;
            this.groupPrices.TabStop = false;
            this.groupPrices.Text = "Fiyatlar";
            // 
            // labelBenzin
            // 
            this.labelBenzin.AutoSize = true;
            this.labelBenzin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBenzin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBenzin.Location = new System.Drawing.Point(20, 40);
            this.labelBenzin.Name = "labelBenzin";
            this.labelBenzin.Size = new System.Drawing.Size(42, 15);
            this.labelBenzin.TabIndex = 0;
            this.labelBenzin.Text = "Benzin";
            // 
            // txtGasolinePrice
            // 
            this.txtGasolinePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtGasolinePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGasolinePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGasolinePrice.ForeColor = System.Drawing.Color.White;
            this.txtGasolinePrice.Location = new System.Drawing.Point(110, 36);
            this.txtGasolinePrice.Name = "txtGasolinePrice";
            this.txtGasolinePrice.ReadOnly = true;
            this.txtGasolinePrice.Size = new System.Drawing.Size(160, 23);
            this.txtGasolinePrice.TabIndex = 3;
            // 
            // labelMotorin
            // 
            this.labelMotorin.AutoSize = true;
            this.labelMotorin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMotorin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMotorin.Location = new System.Drawing.Point(20, 80);
            this.labelMotorin.Name = "labelMotorin";
            this.labelMotorin.Size = new System.Drawing.Size(50, 15);
            this.labelMotorin.TabIndex = 1;
            this.labelMotorin.Text = "Motorin";
            // 
            // txtDieselPrice
            // 
            this.txtDieselPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtDieselPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDieselPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDieselPrice.ForeColor = System.Drawing.Color.White;
            this.txtDieselPrice.Location = new System.Drawing.Point(110, 76);
            this.txtDieselPrice.Name = "txtDieselPrice";
            this.txtDieselPrice.ReadOnly = true;
            this.txtDieselPrice.Size = new System.Drawing.Size(160, 23);
            this.txtDieselPrice.TabIndex = 4;
            // 
            // labelLpg
            // 
            this.labelLpg.AutoSize = true;
            this.labelLpg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLpg.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLpg.Location = new System.Drawing.Point(20, 120);
            this.labelLpg.Name = "labelLpg";
            this.labelLpg.Size = new System.Drawing.Size(28, 15);
            this.labelLpg.TabIndex = 2;
            this.labelLpg.Text = "LPG";
            // 
            // txtLpgPrice
            // 
            this.txtLpgPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtLpgPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLpgPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLpgPrice.ForeColor = System.Drawing.Color.White;
            this.txtLpgPrice.Location = new System.Drawing.Point(110, 116);
            this.txtLpgPrice.Name = "txtLpgPrice";
            this.txtLpgPrice.ReadOnly = true;
            this.txtLpgPrice.Size = new System.Drawing.Size(160, 23);
            this.txtLpgPrice.TabIndex = 5;
            // 
            // groupFuelType
            // 
            this.groupFuelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.groupFuelType.Controls.Add(this.rdbGasoline);
            this.groupFuelType.Controls.Add(this.rdbDiesel);
            this.groupFuelType.Controls.Add(this.rdbLpg);
            this.groupFuelType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupFuelType.ForeColor = System.Drawing.Color.White;
            this.groupFuelType.Location = new System.Drawing.Point(46, 21);
            this.groupFuelType.Name = "groupFuelType";
            this.groupFuelType.Padding = new System.Windows.Forms.Padding(10);
            this.groupFuelType.Size = new System.Drawing.Size(466, 80);
            this.groupFuelType.TabIndex = 8;
            this.groupFuelType.TabStop = false;
            this.groupFuelType.Text = "Yakıt Seçimi";
            // 
            // rdbGasoline
            // 
            this.rdbGasoline.AutoSize = true;
            this.rdbGasoline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbGasoline.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbGasoline.Location = new System.Drawing.Point(24, 36);
            this.rdbGasoline.Name = "rdbGasoline";
            this.rdbGasoline.Size = new System.Drawing.Size(60, 19);
            this.rdbGasoline.TabIndex = 0;
            this.rdbGasoline.TabStop = true;
            this.rdbGasoline.Text = "Benzin";
            this.rdbGasoline.UseVisualStyleBackColor = true;
            // 
            // rdbDiesel
            // 
            this.rdbDiesel.AutoSize = true;
            this.rdbDiesel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbDiesel.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbDiesel.Location = new System.Drawing.Point(175, 36);
            this.rdbDiesel.Name = "rdbDiesel";
            this.rdbDiesel.Size = new System.Drawing.Size(68, 19);
            this.rdbDiesel.TabIndex = 1;
            this.rdbDiesel.TabStop = true;
            this.rdbDiesel.Text = "Motorin";
            this.rdbDiesel.UseVisualStyleBackColor = true;
            // 
            // rdbLpg
            // 
            this.rdbLpg.AutoSize = true;
            this.rdbLpg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbLpg.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdbLpg.Location = new System.Drawing.Point(340, 36);
            this.rdbLpg.Name = "rdbLpg";
            this.rdbLpg.Size = new System.Drawing.Size(46, 19);
            this.rdbLpg.TabIndex = 2;
            this.rdbLpg.TabStop = true;
            this.rdbLpg.Text = "LPG";
            this.rdbLpg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(858, 396);
            this.Controls.Add(this.groupFuelType);
            this.Controls.Add(this.groupPrices);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelLiveFill);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.txtFuelAmount);
            this.Controls.Add(this.labelFuelAmount);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gas Price Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPrices.ResumeLayout(false);
            this.groupPrices.PerformLayout();
            this.groupFuelType.ResumeLayout(false);
            this.groupFuelType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

