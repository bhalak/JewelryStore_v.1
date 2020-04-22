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
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();

        }



        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AuthorizationForm form = new AuthorizationForm();
            //form.Show();
            GlobalInfo.authorizationForm.Show();
            GlobalInfo.mainWindow.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            this.Hide();
            usersForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var storeForm = new StoreForm();
            this.Hide();
            storeForm.Show();
        }

        private void ProductTypesButton_Click(object sender, EventArgs e)
        {
            var typeForm = new PtoductTypesForm();
            this.Hide();
            typeForm.Show();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersForm();
            this.Hide();
            customersForm.Show();
        }
    }
}
