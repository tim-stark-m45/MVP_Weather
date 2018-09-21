namespace MVP_Weather.View
{
    partial class WeatherView
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
            this.CityListbox = new System.Windows.Forms.ListBox();
            this.CityNameTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityListbox
            // 
            this.CityListbox.FormattingEnabled = true;
            this.CityListbox.Location = new System.Drawing.Point(12, 97);
            this.CityListbox.Name = "CityListbox";
            this.CityListbox.Size = new System.Drawing.Size(206, 316);
            this.CityListbox.TabIndex = 0;
            this.CityListbox.SelectedIndexChanged += new System.EventHandler(this.OnCityChanged);
            // 
            // CityNameTextbox
            // 
            this.CityNameTextbox.Location = new System.Drawing.Point(12, 12);
            this.CityNameTextbox.Name = "CityNameTextbox";
            this.CityNameTextbox.Size = new System.Drawing.Size(206, 20);
            this.CityNameTextbox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 52);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(141, 51);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.AutoSize = true;
            this.CityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityNameLabel.Location = new System.Drawing.Point(262, 12);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(195, 46);
            this.CityNameLabel.TabIndex = 4;
            this.CityNameLabel.Text = "CityName";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureLabel.Location = new System.Drawing.Point(262, 74);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(246, 46);
            this.TemperatureLabel.TabIndex = 5;
            this.TemperatureLabel.Text = "Temperature";
            // 
            // WeatherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 425);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.CityNameLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CityNameTextbox);
            this.Controls.Add(this.CityListbox);
            this.Name = "WeatherView";
            this.Text = "WeatherView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CityListbox;
        private System.Windows.Forms.TextBox CityNameTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label CityNameLabel;
        private System.Windows.Forms.Label TemperatureLabel;
    }
}