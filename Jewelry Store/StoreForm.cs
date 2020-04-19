using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Store
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            db.data.Locations.Load();
            dataGridView1.DataSource = db.data.Locations.Local.ToBindingList();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            GlobalInfo.mainWindow.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalInfo.mainWindow.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newShopForm = new NewShopForm();

            do
            {


                DialogResult result = newShopForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (newShopForm.CityTextBox.Text.Trim() == "" ||
                    newShopForm.CountryTextBox.Text.Trim() == "" ||
                    newShopForm.StreetTextBox.Text.Trim() == "" ||
                    newShopForm.NumOfStreetTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Усі поля повинні бути заповнені!");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            //           User newUser = new User();
            //newUser.Login = newShopForm.LoginTextBox.Text;
            //newUser.Password = newUserForm.PasswordTextBox.Text;
            //newUser.Rule_ref = Int32.Parse(newUserForm.LevelAccesComboBox.SelectedValue.ToString());
            //newUser.FullName = newUserForm.FullNameTextBox.Text;
            Location newLocation = new Location();
            Store newStore = new Store();

            newLocation.Country = newShopForm.CountryTextBox.Text;
            newLocation.City = newShopForm.CityTextBox.Text;
            newLocation.Street = newShopForm.StreetTextBox.Text;
            newLocation.NumOfStreet = Int32.Parse(newShopForm.NumOfStreetTextBox.Text);

            db.data.Locations.Add(newLocation);
            db.data.SaveChanges();
            //           db.data.SaveChanges();
            //    db.data.Entry(newLocation).State = EntityState.Added;

            newStore.TotalProductCost = 0;
            newStore.ObjectId = db.data.Locations.Max(l => l.ObjectId);

            db.data.Stores.Add(newStore);
   //         db.data.Entry(newStore).State = EntityState.Added;

            db.data.SaveChanges();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
