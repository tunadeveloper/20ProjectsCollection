namespace _13_RapidAPIWeatherProject
{
    partial class Form1
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
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblWindValue = new System.Windows.Forms.Label();
            this.lblHumidityValue = new System.Windows.Forms.Label();
            this.lblFahrenheitValue = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelWeatherInfo = new System.Windows.Forms.Panel();
            this.panelWeatherDetails = new System.Windows.Forms.Panel();
            this.lblWeatherEmoji = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelWeatherInfo.SuspendLayout();
            this.panelWeatherDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCityName.ForeColor = System.Drawing.Color.White;
            this.lblCityName.Location = new System.Drawing.Point(20, 20);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(107, 32);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "İstanbul";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblToday.Location = new System.Drawing.Point(20, 60);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(55, 21);
            this.lblToday.TabIndex = 1;
            this.lblToday.Text = "Bugün";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(20, 90);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(135, 86);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "22°";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblWind.Location = new System.Drawing.Point(20, 20);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(51, 19);
            this.lblWind.TabIndex = 4;
            this.lblWind.Text = "Rüzgar";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblHumidity.Location = new System.Drawing.Point(20, 50);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(38, 19);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "Nem";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFahrenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblFahrenheit.Location = new System.Drawing.Point(20, 80);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(74, 19);
            this.lblFahrenheit.TabIndex = 6;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblWindValue
            // 
            this.lblWindValue.AutoSize = true;
            this.lblWindValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWindValue.ForeColor = System.Drawing.Color.White;
            this.lblWindValue.Location = new System.Drawing.Point(120, 20);
            this.lblWindValue.Name = "lblWindValue";
            this.lblWindValue.Size = new System.Drawing.Size(25, 19);
            this.lblWindValue.TabIndex = 7;
            this.lblWindValue.Text = "12";
            // 
            // lblHumidityValue
            // 
            this.lblHumidityValue.AutoSize = true;
            this.lblHumidityValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHumidityValue.ForeColor = System.Drawing.Color.White;
            this.lblHumidityValue.Location = new System.Drawing.Point(120, 50);
            this.lblHumidityValue.Name = "lblHumidityValue";
            this.lblHumidityValue.Size = new System.Drawing.Size(25, 19);
            this.lblHumidityValue.TabIndex = 8;
            this.lblHumidityValue.Text = "65";
            // 
            // lblFahrenheitValue
            // 
            this.lblFahrenheitValue.AutoSize = true;
            this.lblFahrenheitValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFahrenheitValue.ForeColor = System.Drawing.Color.White;
            this.lblFahrenheitValue.Location = new System.Drawing.Point(120, 80);
            this.lblFahrenheitValue.Name = "lblFahrenheitValue";
            this.lblFahrenheitValue.Size = new System.Drawing.Size(25, 19);
            this.lblFahrenheitValue.TabIndex = 9;
            this.lblFahrenheitValue.Text = "72";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMain.Controls.Add(this.panelWeatherInfo);
            this.panelMain.Controls.Add(this.panelWeatherDetails);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(400, 332);
            this.panelMain.TabIndex = 10;
            // 
            // panelWeatherInfo
            // 
            this.panelWeatherInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelWeatherInfo.Controls.Add(this.lblWeatherEmoji);
            this.panelWeatherInfo.Controls.Add(this.lblCityName);
            this.panelWeatherInfo.Controls.Add(this.lblToday);
            this.panelWeatherInfo.Controls.Add(this.lblTemperature);
            this.panelWeatherInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWeatherInfo.Location = new System.Drawing.Point(0, 0);
            this.panelWeatherInfo.Name = "panelWeatherInfo";
            this.panelWeatherInfo.Size = new System.Drawing.Size(400, 203);
            this.panelWeatherInfo.TabIndex = 11;
            // 
            // panelWeatherDetails
            // 
            this.panelWeatherDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelWeatherDetails.Controls.Add(this.lblWind);
            this.panelWeatherDetails.Controls.Add(this.lblWindValue);
            this.panelWeatherDetails.Controls.Add(this.lblHumidity);
            this.panelWeatherDetails.Controls.Add(this.lblHumidityValue);
            this.panelWeatherDetails.Controls.Add(this.lblFahrenheit);
            this.panelWeatherDetails.Controls.Add(this.lblFahrenheitValue);
            this.panelWeatherDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWeatherDetails.Location = new System.Drawing.Point(0, 206);
            this.panelWeatherDetails.Name = "panelWeatherDetails";
            this.panelWeatherDetails.Size = new System.Drawing.Size(400, 126);
            this.panelWeatherDetails.TabIndex = 12;
            // 
            // lblWeatherEmoji
            // 
            this.lblWeatherEmoji.AutoSize = true;
            this.lblWeatherEmoji.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeatherEmoji.ForeColor = System.Drawing.Color.White;
            this.lblWeatherEmoji.Location = new System.Drawing.Point(263, 20);
            this.lblWeatherEmoji.Name = "lblWeatherEmoji";
            this.lblWeatherEmoji.Size = new System.Drawing.Size(125, 86);
            this.lblWeatherEmoji.TabIndex = 3;
            this.lblWeatherEmoji.Text = "⛅";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(400, 332);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hava Durumu Kartı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelWeatherInfo.ResumeLayout(false);
            this.panelWeatherInfo.PerformLayout();
            this.panelWeatherDetails.ResumeLayout(false);
            this.panelWeatherDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblWindValue;
        private System.Windows.Forms.Label lblHumidityValue;
        private System.Windows.Forms.Label lblFahrenheitValue;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelWeatherInfo;
        private System.Windows.Forms.Panel panelWeatherDetails;
        private System.Windows.Forms.Label lblWeatherEmoji;
    }
}

