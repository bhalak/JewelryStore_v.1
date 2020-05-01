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
    public partial class NewTypeForm : Form
    {
        public NewTypeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            TypeNameTextBox.MaxLength = 50;
        }

        private void NewTypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
