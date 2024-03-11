namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.feelsLikeTemperatureLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.enterCityNameLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(75, 43);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 13);
            this.cityLabel.TabIndex = 0;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(75, 68);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(0, 13);
            this.countryLabel.TabIndex = 1;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(75, 95);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(0, 13);
            this.temperatureLabel.TabIndex = 3;
            // 
            // feelsLikeTemperatureLabel
            // 
            this.feelsLikeTemperatureLabel.AutoSize = true;
            this.feelsLikeTemperatureLabel.Location = new System.Drawing.Point(75, 122);
            this.feelsLikeTemperatureLabel.Name = "feelsLikeTemperatureLabel";
            this.feelsLikeTemperatureLabel.Size = new System.Drawing.Size(0, 13);
            this.feelsLikeTemperatureLabel.TabIndex = 4;
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Location = new System.Drawing.Point(75, 149);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.windSpeedLabel.TabIndex = 5;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(276, 15);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.cityNameTextBox.TabIndex = 6;
            this.cityNameTextBox.TextChanged += new System.EventHandler(this.cityNameTextBox_TextChanged);
            // 
            // enterCityNameLabel
            // 
            this.enterCityNameLabel.AutoSize = true;
            this.enterCityNameLabel.Location = new System.Drawing.Point(75, 15);
            this.enterCityNameLabel.Name = "enterCityNameLabel";
            this.enterCityNameLabel.Size = new System.Drawing.Size(107, 13);
            this.enterCityNameLabel.TabIndex = 7;
            this.enterCityNameLabel.Text = "Введіть назву міста";
            this.enterCityNameLabel.Click += new System.EventHandler(this.enterCityNameLabel_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterCityNameLabel);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.feelsLikeTemperatureLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label feelsLikeTemperatureLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Label enterCityNameLabel;
        private System.Windows.Forms.Timer timer2;
    }
}

