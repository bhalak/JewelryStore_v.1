using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Store
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
            this.LoginTextBox.MaxLength = 50;
            this.FullNameTextBox.MaxLength = 150;
            this.PasswordTextBox.MaxLength = 8;

        }

        private void LevelAccesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
