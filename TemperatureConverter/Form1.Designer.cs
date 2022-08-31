namespace TemperatureConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.measureFromCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.measureToCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.conversionTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // measureFromCB
            // 
            this.measureFromCB.FormattingEnabled = true;
            this.measureFromCB.Items.AddRange(new object[] {
            "Celsius °C",
            "Fahrenheit °F",
            "Kelvin °K"});
            this.measureFromCB.Location = new System.Drawing.Point(130, 118);
            this.measureFromCB.Name = "measureFromCB";
            this.measureFromCB.Size = new System.Drawing.Size(121, 21);
            this.measureFromCB.TabIndex = 1;
            this.measureFromCB.Text = "Select Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Measurement From";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(292, 118);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 3;
            // 
            // measureToCB
            // 
            this.measureToCB.FormattingEnabled = true;
            this.measureToCB.Items.AddRange(new object[] {
            "Celsius °C",
            "Fahrenheit °F",
            "Kelvin °K"});
            this.measureToCB.Location = new System.Drawing.Point(432, 118);
            this.measureToCB.Name = "measureToCB";
            this.measureToCB.Size = new System.Drawing.Size(121, 21);
            this.measureToCB.TabIndex = 4;
            this.measureToCB.Text = "Select Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Measurement To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Conversion";
            // 
            // conversionTextBox
            // 
            this.conversionTextBox.Location = new System.Drawing.Point(292, 202);
            this.conversionTextBox.Name = "conversionTextBox";
            this.conversionTextBox.Size = new System.Drawing.Size(100, 20);
            this.conversionTextBox.TabIndex = 8;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(292, 156);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(100, 23);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(292, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(214, 13);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(270, 13);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Please select an appropriate unit of measure to convert.";
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 257);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.conversionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.measureToCB);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.measureFromCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox measureFromCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox measureToCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox conversionTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

