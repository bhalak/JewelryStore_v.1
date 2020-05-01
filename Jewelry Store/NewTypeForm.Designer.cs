namespace Jewelry_Store
{
    partial class NewTypeForm
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
            this.Add_Cancel_btn = new System.Windows.Forms.Button();
            this.Add_OK_btn = new System.Windows.Forms.Button();
            this.TypeNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersGroupBox
            // 
            this.UsersGroupBox.Controls.Add(this.Add_Cancel_btn);
            this.UsersGroupBox.Controls.Add(this.Add_OK_btn);
            this.UsersGroupBox.Controls.Add(this.TypeNameTextBox);
            this.UsersGroupBox.Controls.Add(this.LoginLabel);
            this.UsersGroupBox.Location = new System.Drawing.Point(21, 28);
            this.UsersGroupBox.Name = "UsersGroupBox";
            this.UsersGroupBox.Size = new System.Drawing.Size(348, 142);
            this.UsersGroupBox.TabIndex = 8;
            this.UsersGroupBox.TabStop = false;
            this.UsersGroupBox.Text = "Тип";
            // 
            // Add_Cancel_btn
            // 
            this.Add_Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add_Cancel_btn.Location = new System.Drawing.Point(138, 98);
            this.Add_Cancel_btn.Name = "Add_Cancel_btn";
            this.Add_Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Cancel_btn.TabIndex = 4;
            this.Add_Cancel_btn.Text = "Cancel";
            this.Add_Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Add_OK_btn
            // 
            this.Add_OK_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add_OK_btn.Location = new System.Drawing.Point(57, 98);
            this.Add_OK_btn.Name = "Add_OK_btn";
            this.Add_OK_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_OK_btn.TabIndex = 3;
            this.Add_OK_btn.Text = "OK";
            this.Add_OK_btn.UseVisualStyleBackColor = true;
            // 
            // TypeNameTextBox
            // 
            this.TypeNameTextBox.Location = new System.Drawing.Point(138, 45);
            this.TypeNameTextBox.Name = "TypeNameTextBox";
            this.TypeNameTextBox.Size = new System.Drawing.Size(182, 22);
            this.TypeNameTextBox.TabIndex = 5;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(25, 50);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(86, 17);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Назва типу:";
            // 
            // NewTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 197);
            this.Controls.Add(this.UsersGroupBox);
            this.Name = "NewTypeForm";
            this.Text = "Новий тип";
            this.Load += new System.EventHandler(this.NewTypeForm_Load);
            this.UsersGroupBox.ResumeLayout(false);
            this.UsersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsersGroupBox;
        private System.Windows.Forms.Button Add_Cancel_btn;
        private System.Windows.Forms.Button Add_OK_btn;
        protected internal System.Windows.Forms.TextBox TypeNameTextBox;
        private System.Windows.Forms.Label LoginLabel;
    }
}