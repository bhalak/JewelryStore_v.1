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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            EmailTextBox.MaxLength = 50;
            PhoneNumberTextBox.MaxLength = 12;

        }

        private void UsersGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
