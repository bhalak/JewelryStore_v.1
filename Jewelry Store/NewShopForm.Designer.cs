namespace Jewelry_Store
{
    partial class NewShopForm
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
            this.UsersGroupBox = new System.Windows.Forms.GroupBox();
            this.NumOfStreetTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Cancel_btn = new System.Windows.Forms.Button();
            this.Add_OK_btn = new System.Windows.Forms.Button();
            this.LevelAccesLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PasportCodeLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersGroupBox
            // 
            this.UsersGroupBox.Controls.Add(this.NumOfStreetTextBox);
            this.UsersGroupBox.Controls.Add(this.CityTextBox);
            this.UsersGroupBox.Controls.Add(this.label1);
            this.UsersGroupBox.Controls.Add(this.Add_Cancel_btn);
            this.UsersGroupBox.Controls.Add(this.Add_OK_btn);
            this.UsersGroupBox.Controls.Add(this.LevelAccesLabel);
            this.UsersGroupBox.Controls.Add(this.StreetTextBox);
            this.UsersGroupBox.Controls.Add(this.CountryTextBox);
            this.UsersGroupBox.Controls.Add(this.PasportCodeLabel);
            this.UsersGroupBox.Controls.Add(this.LoginLabel);
            this.UsersGroupBox.Location = new System.Drawing.Point(12, 21);
            this.UsersGroupBox.Name = "UsersGroupBox";
            this.UsersGroupBox.Size = new System.Drawing.Size(344, 272);
            this.UsersGroupBox.TabIndex = 7;
            this.UsersGroupBox.TabStop = false;
            this.UsersGroupBox.Text = "Магазин";
            this.UsersGroupBox.Enter += new System.EventHandler(this.UsersGroupBox_Enter);
            // 
            // NumOfStreetTextBox
            // 
            this.NumOfStreetTextBox.Location = new System.Drawing.Point(138, 165);
            this.NumOfStreetTextBox.MaxLength = 8;
            this.NumOfStreetTextBox.Name = "NumOfStreetTextBox";
            this.NumOfStreetTextBox.Size = new System.Drawing.Size(182, 22);
            this.NumOfStreetTextBox.TabIndex = 11;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(138, 84);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(182, 22);
            this.CityTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Місто:";
            // 
            // Add_Cancel_btn
            // 
            this.Add_Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add_Cancel_btn.Location = new System.Drawing.Point(157, 226);
            this.Add_Cancel_btn.Name = "Add_Cancel_btn";
            this.Add_Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Cancel_btn.TabIndex = 4;
            this.Add_Cancel_btn.Text = "Cancel";
            this.Add_Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Add_OK_btn
            // 
            this.Add_OK_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add_OK_btn.Location = new System.Drawing.Point(76, 226);
            this.Add_OK_btn.Name = "Add_OK_btn";
            this.Add_OK_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_OK_btn.TabIndex = 3;
            this.Add_OK_btn.Text = "OK";
            this.Add_OK_btn.UseVisualStyleBackColor = true;
            // 
            // LevelAccesLabel
            // 
            this.LevelAccesLabel.AutoSize = true;
            this.LevelAccesLabel.Location = new System.Drawing.Point(25, 170);
            this.LevelAccesLabel.Name = "LevelAccesLabel";
            this.LevelAccesLabel.Size = new System.Drawing.Size(100, 17);
            this.LevelAccesLabel.TabIndex = 7;
            this.LevelAccesLabel.Text = "Номер вулиці:";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(138, 126);
            this.StreetTextBox.MaxLength = 8;
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(182, 22);
            this.StreetTextBox.TabIndex = 6;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(138, 45);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(182, 22);
            this.CountryTextBox.TabIndex = 5;
            // 
            // PasportCodeLabel
            // 
            this.PasportCodeLabel.AutoSize = true;
            this.PasportCodeLabel.Location = new System.Drawing.Point(25, 131);
            this.PasportCodeLabel.Name = "PasportCodeLabel";
            this.PasportCodeLabel.Size = new System.Drawing.Size(60, 17);
            this.PasportCodeLabel.TabIndex = 1;
            this.PasportCodeLabel.Text = "Вулиця:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(25, 50);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(56, 17);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Країна:";
            // 
            // NewShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 323);
            this.Controls.Add(this.UsersGroupBox);
            this.Name = "NewShopForm";
            this.Text = "Дані про новий магазин";
            this.Load += new System.EventHandler(this.NewShopForm_Load);
            this.UsersGroupBox.ResumeLayout(false);
            this.UsersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsersGroupBox;
        protected internal System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Cancel_btn;
        private System.Windows.Forms.Button Add_OK_btn;
        private System.Windows.Forms.Label LevelAccesLabel;
        protected internal System.Windows.Forms.TextBox StreetTextBox;
        protected internal System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label PasportCodeLabel;
        private System.Windows.Forms.Label LoginLabel;
        protected internal System.Windows.Forms.TextBox NumOfStreetTextBox;
    }
}