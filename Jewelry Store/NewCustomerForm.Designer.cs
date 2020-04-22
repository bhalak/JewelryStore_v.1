namespace Jewelry_Store
{
    partial class NewCustomerForm
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
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Cancel_btn = new System.Windows.Forms.Button();
            this.Add_OK_btn = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersGroupBox
            // 
            this.UsersGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.UsersGroupBox.Controls.Add(this.label1);
            this.UsersGroupBox.Controls.Add(this.Add_Cancel_btn);
            this.UsersGroupBox.Controls.Add(this.Add_OK_btn);
            this.UsersGroupBox.Controls.Add(this.EmailTextBox);
            this.UsersGroupBox.Controls.Add(this.LoginLabel);
            this.UsersGroupBox.Location = new System.Drawing.Point(21, 22);
            this.UsersGroupBox.Name = "UsersGroupBox";
            this.UsersGroupBox.Size = new System.Drawing.Size(371, 187);
            this.UsersGroupBox.TabIndex = 8;
            this.UsersGroupBox.TabStop = false;
            this.UsersGroupBox.Text = "Покупець";
            this.UsersGroupBox.Enter += new System.EventHandler(this.UsersGroupBox_Enter);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(168, 86);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(182, 22);
            this.PhoneNumberTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер телефону:";
            // 
            // Add_Cancel_btn
            // 
            this.Add_Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add_Cancel_btn.Location = new System.Drawing.Point(168, 142);
            this.Add_Cancel_btn.Name = "Add_Cancel_btn";
            this.Add_Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Cancel_btn.TabIndex = 4;
            this.Add_Cancel_btn.Text = "Cancel";
            this.Add_Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Add_OK_btn
            // 
            this.Add_OK_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add_OK_btn.Location = new System.Drawing.Point(87, 142);
            this.Add_OK_btn.Name = "Add_OK_btn";
            this.Add_OK_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_OK_btn.TabIndex = 3;
            this.Add_OK_btn.Text = "OK";
            this.Add_OK_btn.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(168, 50);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(182, 22);
            this.EmailTextBox.TabIndex = 5;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(25, 50);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(137, 17);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Електронна пошта:";
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 222);
            this.Controls.Add(this.UsersGroupBox);
            this.Name = "NewCustomerForm";
            this.Text = "Новий покупець";
            this.UsersGroupBox.ResumeLayout(false);
            this.UsersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsersGroupBox;
        protected internal System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Cancel_btn;
        private System.Windows.Forms.Button Add_OK_btn;
        protected internal System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label LoginLabel;
    }
}