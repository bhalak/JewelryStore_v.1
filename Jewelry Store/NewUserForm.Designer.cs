namespace Jewelry_Store
{
    partial class NewUserForm
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LevelAccesComboBox = new System.Windows.Forms.ComboBox();
            this.Add_Cancel_btn = new System.Windows.Forms.Button();
            this.Add_OK_btn = new System.Windows.Forms.Button();
            this.LevelAccesLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasportCodeLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersGroupBox
            // 
            this.UsersGroupBox.Controls.Add(this.FullNameTextBox);
            this.UsersGroupBox.Controls.Add(this.label1);
            this.UsersGroupBox.Controls.Add(this.LevelAccesComboBox);
            this.UsersGroupBox.Controls.Add(this.Add_Cancel_btn);
            this.UsersGroupBox.Controls.Add(this.Add_OK_btn);
            this.UsersGroupBox.Controls.Add(this.LevelAccesLabel);
            this.UsersGroupBox.Controls.Add(this.PasswordTextBox);
            this.UsersGroupBox.Controls.Add(this.LoginTextBox);
            this.UsersGroupBox.Controls.Add(this.PasportCodeLabel);
            this.UsersGroupBox.Controls.Add(this.LoginLabel);
            this.UsersGroupBox.Location = new System.Drawing.Point(29, 31);
            this.UsersGroupBox.Name = "UsersGroupBox";
            this.UsersGroupBox.Size = new System.Drawing.Size(344, 272);
            this.UsersGroupBox.TabIndex = 6;
            this.UsersGroupBox.TabStop = false;
            this.UsersGroupBox.Text = "Користувач";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(138, 84);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(182, 22);
            this.FullNameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ПІБ:";
            // 
            // LevelAccesComboBox
            // 
            this.LevelAccesComboBox.DisplayMember = "LevelAccess";
            this.LevelAccesComboBox.FormattingEnabled = true;
            this.LevelAccesComboBox.Location = new System.Drawing.Point(138, 167);
            this.LevelAccesComboBox.Name = "LevelAccesComboBox";
            this.LevelAccesComboBox.Size = new System.Drawing.Size(121, 24);
            this.LevelAccesComboBox.TabIndex = 8;
            this.LevelAccesComboBox.ValueMember = "RuleId";
            this.LevelAccesComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelAccesComboBox_SelectedIndexChanged);
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
            this.LevelAccesLabel.Size = new System.Drawing.Size(110, 17);
            this.LevelAccesLabel.TabIndex = 7;
            this.LevelAccesLabel.Text = "Рівень доступу:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(138, 126);
            this.PasswordTextBox.MaxLength = 8;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(182, 22);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(138, 45);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(182, 22);
            this.LoginTextBox.TabIndex = 5;
            // 
            // PasportCodeLabel
            // 
            this.PasportCodeLabel.AutoSize = true;
            this.PasportCodeLabel.Location = new System.Drawing.Point(25, 131);
            this.PasportCodeLabel.Name = "PasportCodeLabel";
            this.PasportCodeLabel.Size = new System.Drawing.Size(61, 17);
            this.PasportCodeLabel.TabIndex = 1;
            this.PasportCodeLabel.Text = "Пароль:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(25, 50);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 17);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логін:";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 315);
            this.Controls.Add(this.UsersGroupBox);
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новий користувач";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.UsersGroupBox.ResumeLayout(false);
            this.UsersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsersGroupBox;
        protected internal System.Windows.Forms.ComboBox LevelAccesComboBox;
        private System.Windows.Forms.Button Add_Cancel_btn;
        private System.Windows.Forms.Button Add_OK_btn;
        private System.Windows.Forms.Label LevelAccesLabel;
        protected internal System.Windows.Forms.TextBox PasswordTextBox;
        protected internal System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasportCodeLabel;
        private System.Windows.Forms.Label LoginLabel;
        protected internal System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}