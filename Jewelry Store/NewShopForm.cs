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
    public partial class NewShopForm : Form
    {
        public NewShopForm()
        {
            InitializeComponent();
            this.CountryTextBox.MaxLength = 50;
            this.CityTextBox.MaxLength = 50;
            this.StreetTextBox.MaxLength = 50;
            this.NumOfStreetTextBox.MaxLength = 6;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void NewShopForm_Load(object sender, EventArgs e)
        {

        }
    }
}
