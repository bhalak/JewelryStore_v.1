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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            db.data.Customers.Load();
            dataGridView1.DataSource = db.data.Customers.Local.ToBindingList();
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
            try
            {
                var newCustomerForm = new NewCustomerForm();

                do
                {
                    DialogResult result = newCustomerForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }

                    if (newCustomerForm.PhoneNumberTextBox.Text.Trim() == "" ||
                        newCustomerForm.EmailTextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Усі поля повинні бути заповнені!");
                    }
                    else if (!newCustomerForm.EmailTextBox.Text.ToString().Contains("@"))
                    {
                        MessageBox.Show("Неправильний введені дані пошти " +
                                        "Пошта повинна бути формату exemple@mail.com.");
                    }
                    else if (newCustomerForm.PhoneNumberTextBox.Text.Trim().Length != 12 ||
                             !Int64.TryParse(newCustomerForm.PhoneNumberTextBox.Text, out long a))
                    {
                        MessageBox.Show("Неправильний введені дані номера телефону " +
                                        "Номер телефону повинен бути формату код країни + номер," +
                                        "наприклад 380972343467.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                Customer newCustomer = new Customer();
                newCustomer.Email = newCustomerForm.EmailTextBox.Text;
                newCustomer.PhoneNumber = Int64.Parse(newCustomerForm.PhoneNumberTextBox.Text);
                newCustomer.AccountSum = 0;

                db.data.Customers.Add(newCustomer);
                db.data.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error occured: " + exception.Message + " - " + exception.Source);
                throw;
            }

                  
        }

        private void AlertBtn_Click(object sender, EventArgs e)
        {
            try
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

                    Customer newCustomer = db.data.Customers.Find(id);
                    var newCustomerForm = new NewCustomerForm();

                    newCustomerForm.EmailTextBox.Text = newCustomer.Email;
                    newCustomerForm.PhoneNumberTextBox.Text = newCustomer.PhoneNumber.ToString();

                    do
                    {
                        DialogResult result = newCustomerForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                        {
                            return;
                        }

                        if (newCustomerForm.PhoneNumberTextBox.Text.Trim() == "" ||
                            newCustomerForm.EmailTextBox.Text.Trim() == "")
                        {
                            MessageBox.Show("Усі поля повинні бути заповнені!");
                        }
                        else if (!newCustomerForm.EmailTextBox.Text.ToString().Contains("@"))
                        {
                            MessageBox.Show("Неправильний введені дані пошти " +
                                            "Пошта повинна бути формату exemple@mail.com.");
                        }
                        else if (newCustomerForm.PhoneNumberTextBox.Text.Trim().Length != 12 ||
                                 !Int64.TryParse(newCustomerForm.PhoneNumberTextBox.Text, out long a))
                        {
                            MessageBox.Show("Неправильний введені дані номера телефону " +
                                            "Номер телефону повинен бути формату код країни + номер," +
                                            "наприклад 380972343467.");
                        }
                        else
                        {
                            break;
                        }
                    } while (true);

                    newCustomer.Email = newCustomerForm.EmailTextBox.Text;
                    newCustomer.PhoneNumber = Int64.Parse(newCustomerForm.PhoneNumberTextBox.Text);

                    db.data.Entry(newCustomer).State = EntityState.Modified;
                    db.data.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error occured: " + exception.Message + " - " + exception.Source);
                throw;
            }

            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
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

                    Customer customer = db.data.Customers.Find(id);

                    db.data.Customers.Remove(customer);

                    db.data.SaveChanges();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error occured: " + exception.Message + " - " + exception.Source);
                throw;
            }
            
        }
    }
}
