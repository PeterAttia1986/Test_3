namespace Test_3
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
            this.Car_radioButton = new System.Windows.Forms.RadioButton();
            this.Owner_radioButton = new System.Windows.Forms.RadioButton();
            this.Car_Registration_groupBox = new System.Windows.Forms.GroupBox();
            this.Owner_Registration_groupBox = new System.Windows.Forms.GroupBox();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Make_comboBox = new System.Windows.Forms.ComboBox();
            this.Model_comboBox = new System.Windows.Forms.ComboBox();
            this.Year_comboBox = new System.Windows.Forms.ComboBox();
            this.Make_label = new System.Windows.Forms.Label();
            this.Model_label = new System.Windows.Forms.Label();
            this.Year_label = new System.Windows.Forms.Label();
            this.Telephone_label = new System.Windows.Forms.Label();
            this.Last_Name_label = new System.Windows.Forms.Label();
            this.First_Name_label = new System.Windows.Forms.Label();
            this.Telephone_comboBox = new System.Windows.Forms.ComboBox();
            this.Last_Name_comboBox = new System.Windows.Forms.ComboBox();
            this.First_Name_comboBox = new System.Windows.Forms.ComboBox();
            this.Car_Registration_groupBox.SuspendLayout();
            this.Owner_Registration_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Car_radioButton
            // 
            this.Car_radioButton.AutoSize = true;
            this.Car_radioButton.Location = new System.Drawing.Point(187, 80);
            this.Car_radioButton.Name = "Car_radioButton";
            this.Car_radioButton.Size = new System.Drawing.Size(41, 17);
            this.Car_radioButton.TabIndex = 0;
            this.Car_radioButton.TabStop = true;
            this.Car_radioButton.Text = "Car";
            this.Car_radioButton.UseVisualStyleBackColor = true;
            this.Car_radioButton.CheckedChanged += new System.EventHandler(this.Car_radioButton_CheckedChanged);
            // 
            // Owner_radioButton
            // 
            this.Owner_radioButton.AutoSize = true;
            this.Owner_radioButton.Location = new System.Drawing.Point(496, 80);
            this.Owner_radioButton.Name = "Owner_radioButton";
            this.Owner_radioButton.Size = new System.Drawing.Size(56, 17);
            this.Owner_radioButton.TabIndex = 1;
            this.Owner_radioButton.TabStop = true;
            this.Owner_radioButton.Text = "Owner";
            this.Owner_radioButton.UseVisualStyleBackColor = true;
            this.Owner_radioButton.CheckedChanged += new System.EventHandler(this.Owner_radioButton_CheckedChanged);
            // 
            // Car_Registration_groupBox
            // 
            this.Car_Registration_groupBox.Controls.Add(this.Year_label);
            this.Car_Registration_groupBox.Controls.Add(this.Model_label);
            this.Car_Registration_groupBox.Controls.Add(this.Make_label);
            this.Car_Registration_groupBox.Controls.Add(this.Year_comboBox);
            this.Car_Registration_groupBox.Controls.Add(this.Model_comboBox);
            this.Car_Registration_groupBox.Controls.Add(this.Make_comboBox);
            this.Car_Registration_groupBox.Location = new System.Drawing.Point(61, 133);
            this.Car_Registration_groupBox.Name = "Car_Registration_groupBox";
            this.Car_Registration_groupBox.Size = new System.Drawing.Size(287, 308);
            this.Car_Registration_groupBox.TabIndex = 2;
            this.Car_Registration_groupBox.TabStop = false;
            this.Car_Registration_groupBox.Text = "Car Registration";
            // 
            // Owner_Registration_groupBox
            // 
            this.Owner_Registration_groupBox.Controls.Add(this.Telephone_label);
            this.Owner_Registration_groupBox.Controls.Add(this.First_Name_label);
            this.Owner_Registration_groupBox.Controls.Add(this.Last_Name_label);
            this.Owner_Registration_groupBox.Controls.Add(this.First_Name_comboBox);
            this.Owner_Registration_groupBox.Controls.Add(this.Last_Name_comboBox);
            this.Owner_Registration_groupBox.Controls.Add(this.Telephone_comboBox);
            this.Owner_Registration_groupBox.Location = new System.Drawing.Point(397, 133);
            this.Owner_Registration_groupBox.Name = "Owner_Registration_groupBox";
            this.Owner_Registration_groupBox.Size = new System.Drawing.Size(287, 308);
            this.Owner_Registration_groupBox.TabIndex = 3;
            this.Owner_Registration_groupBox.TabStop = false;
            this.Owner_Registration_groupBox.Text = "Owner";
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(187, 472);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(143, 33);
            this.Reset_button.TabIndex = 4;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(409, 472);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(143, 33);
            this.Save_button.TabIndex = 5;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Make_comboBox
            // 
            this.Make_comboBox.FormattingEnabled = true;
            this.Make_comboBox.Location = new System.Drawing.Point(86, 66);
            this.Make_comboBox.Name = "Make_comboBox";
            this.Make_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Make_comboBox.TabIndex = 0;
            this.Make_comboBox.SelectedIndexChanged += new System.EventHandler(this.Make_comboBox_SelectedIndexChanged);
            // 
            // Model_comboBox
            // 
            this.Model_comboBox.FormattingEnabled = true;
            this.Model_comboBox.Location = new System.Drawing.Point(86, 125);
            this.Model_comboBox.Name = "Model_comboBox";
            this.Model_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Model_comboBox.TabIndex = 1;
            // 
            // Year_comboBox
            // 
            this.Year_comboBox.FormattingEnabled = true;
            this.Year_comboBox.Location = new System.Drawing.Point(86, 184);
            this.Year_comboBox.Name = "Year_comboBox";
            this.Year_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Year_comboBox.TabIndex = 2;
            // 
            // Make_label
            // 
            this.Make_label.AutoSize = true;
            this.Make_label.Location = new System.Drawing.Point(23, 69);
            this.Make_label.Name = "Make_label";
            this.Make_label.Size = new System.Drawing.Size(34, 13);
            this.Make_label.TabIndex = 3;
            this.Make_label.Text = "Make";
            // 
            // Model_label
            // 
            this.Model_label.AutoSize = true;
            this.Model_label.Location = new System.Drawing.Point(23, 128);
            this.Model_label.Name = "Model_label";
            this.Model_label.Size = new System.Drawing.Size(36, 13);
            this.Model_label.TabIndex = 4;
            this.Model_label.Text = "Model";
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.Location = new System.Drawing.Point(23, 187);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(29, 13);
            this.Year_label.TabIndex = 5;
            this.Year_label.Text = "Year";
            // 
            // Telephone_label
            // 
            this.Telephone_label.AutoSize = true;
            this.Telephone_label.Location = new System.Drawing.Point(44, 184);
            this.Telephone_label.Name = "Telephone_label";
            this.Telephone_label.Size = new System.Drawing.Size(58, 13);
            this.Telephone_label.TabIndex = 11;
            this.Telephone_label.Text = "Telephone";
            // 
            // Last_Name_label
            // 
            this.Last_Name_label.AutoSize = true;
            this.Last_Name_label.Location = new System.Drawing.Point(44, 125);
            this.Last_Name_label.Name = "Last_Name_label";
            this.Last_Name_label.Size = new System.Drawing.Size(58, 13);
            this.Last_Name_label.TabIndex = 10;
            this.Last_Name_label.Text = "Last Name";
            // 
            // First_Name_label
            // 
            this.First_Name_label.AutoSize = true;
            this.First_Name_label.Location = new System.Drawing.Point(44, 66);
            this.First_Name_label.Name = "First_Name_label";
            this.First_Name_label.Size = new System.Drawing.Size(57, 13);
            this.First_Name_label.TabIndex = 9;
            this.First_Name_label.Text = "First Name";
            // 
            // Telephone_comboBox
            // 
            this.Telephone_comboBox.FormattingEnabled = true;
            this.Telephone_comboBox.Location = new System.Drawing.Point(107, 181);
            this.Telephone_comboBox.Name = "Telephone_comboBox";
            this.Telephone_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Telephone_comboBox.TabIndex = 8;
            // 
            // Last_Name_comboBox
            // 
            this.Last_Name_comboBox.FormattingEnabled = true;
            this.Last_Name_comboBox.Location = new System.Drawing.Point(107, 122);
            this.Last_Name_comboBox.Name = "Last_Name_comboBox";
            this.Last_Name_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Last_Name_comboBox.TabIndex = 7;
            // 
            // First_Name_comboBox
            // 
            this.First_Name_comboBox.FormattingEnabled = true;
            this.First_Name_comboBox.Location = new System.Drawing.Point(107, 63);
            this.First_Name_comboBox.Name = "First_Name_comboBox";
            this.First_Name_comboBox.Size = new System.Drawing.Size(121, 21);
            this.First_Name_comboBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Owner_Registration_groupBox);
            this.Controls.Add(this.Car_Registration_groupBox);
            this.Controls.Add(this.Owner_radioButton);
            this.Controls.Add(this.Car_radioButton);
            this.Name = "Form1";
            this.Text = "Carwash System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Car_Registration_groupBox.ResumeLayout(false);
            this.Car_Registration_groupBox.PerformLayout();
            this.Owner_Registration_groupBox.ResumeLayout(false);
            this.Owner_Registration_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Car_radioButton;
        private System.Windows.Forms.RadioButton Owner_radioButton;
        private System.Windows.Forms.GroupBox Car_Registration_groupBox;
        private System.Windows.Forms.GroupBox Owner_Registration_groupBox;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label Year_label;
        private System.Windows.Forms.Label Model_label;
        private System.Windows.Forms.Label Make_label;
        private System.Windows.Forms.ComboBox Year_comboBox;
        private System.Windows.Forms.ComboBox Model_comboBox;
        private System.Windows.Forms.ComboBox Make_comboBox;
        private System.Windows.Forms.Label Telephone_label;
        private System.Windows.Forms.Label First_Name_label;
        private System.Windows.Forms.Label Last_Name_label;
        private System.Windows.Forms.ComboBox First_Name_comboBox;
        private System.Windows.Forms.ComboBox Last_Name_comboBox;
        private System.Windows.Forms.ComboBox Telephone_comboBox;
    }
}

