using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Store
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.PasswordTextBox.MaxLength = 8;
            this.LoginTextBox.MaxLength = 50;
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginTextBox.Text.Trim() == "" || PasswordTextBox.Text.Trim() == "")
                {
                    IncorrectDatrLabel.Text = "Пароль або логін не можуть бути попрожніми";
                    return;
                }

                var userLogin = LoginTextBox.Text;

                var UsersCount = db.data.Users
                    .Where(u => u.Login == userLogin && u.Password == PasswordTextBox.Text)
                    .Count();

                if (UsersCount == 0)
                {
                    IncorrectDatrLabel.Text = "Неправильно введений пароль або логін!";
                    return;
                }

                GlobalInfo.authorizationForm = this;
                GlobalInfo.mainWindow = new MainWindowForm();
                GlobalInfo.mainWindow.LoginLabel.Text = userLogin;
                GlobalInfo.currentUser = db.data.Users
                    .FirstOrDefault(u => u.Login == userLogin);

                PasswordTextBox.Text = "";
                LoginTextBox.Text = "";

                GlobalInfo.authorizationForm.Hide();
                GlobalInfo.mainWindow.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error occured: " + exception.Message + " - " + exception.Source);
                throw;
            }          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
