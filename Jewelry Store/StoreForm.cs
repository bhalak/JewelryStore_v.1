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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

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

            Location newLocation = new Location();
            newLocation.Country = newShopForm.CountryTextBox.Text;
            newLocation.City = newShopForm.CityTextBox.Text;
            newLocation.Street = newShopForm.StreetTextBox.Text;
            newLocation.NumOfStreet = newShopForm.NumOfStreetTextBox.Text;

            db.data.Locations.Add(newLocation);
            db.data.SaveChanges();

            Store newStore = new Store();
            newStore.TotalProductCost = 0;
            newStore.ObjectId = db.data.Locations.Max(l => l.ObjectId);

            db.data.Stores.Add(newStore);
            db.data.SaveChanges();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

                if (!converted)
                {
                    return;
                }

                Store store = db.data.Stores.Find(id);

                db.data.Stores.Remove(store);

                Location location = db.data.Locations.Find(id);
                db.data.Locations.Remove(location);

                db.data.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void AlertBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

                if (!converted)
                {
                    return;
                }

                Location newLocation = db.data.Locations.Find(id);
                var newShopForm = new NewShopForm();

                newShopForm.CountryTextBox.Text = newLocation.Country;
                newShopForm.CityTextBox.Text = newLocation.City;
                newShopForm.StreetTextBox.Text = newLocation.Street;
                newShopForm.NumOfStreetTextBox.Text = newLocation.NumOfStreet;

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

                newLocation.Country = newShopForm.CountryTextBox.Text;
                newLocation.City = newShopForm.CityTextBox.Text;
                newLocation.Street = newShopForm.StreetTextBox.Text;
                newLocation.NumOfStreet = newShopForm.NumOfStreetTextBox.Text;

                db.data.Entry(newLocation).State = EntityState.Modified;
                db.data.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
