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
    public partial class SaleForm : Form
    {
        private List<Product> productsList;
        public SaleForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.ReadOnly = true;
            productsList = new List<Product>();
            productsList.AddRange( db.data.Products.Where(p=>p.IsAvaliable) );


            dataGridView1.DataSource = productsList;
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

        private void SellButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (IsCustomerInSystemCheckBox.Checked)
                {
                    if (CustomerIdTextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Комірка id користувача не заповнена.");
                        return;
                    }

                    int customerId = Int32.Parse(CustomerIdTextBox.Text);
                    if (!db.data.Customers.Any(c => c.CustomerId == customerId))
                    {
                        MessageBox.Show("Такого id користувача не існує.");
                        return;
                    }
                }

                Order newOrder = new Order();

                newOrder.User_ref = GlobalInfo.currentUser.UserId;
                newOrder.Date = DateTime.Now;
                newOrder.TotalPrice = 0;

                db.data.Orders.Add(newOrder);
                db.data.SaveChanges();

                int currentOrderId = db.data.Orders.Max(o => o.OrderId);

                Order currentOrder = db.data.Orders.Find(currentOrderId);

                Product product;
                Order_Product orderProduct;

                decimal totalSum = 0;
                
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    int id = Int32.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());

                    product = db.data.Products.Find(id);

                    product.IsAvaliable = false;

                    orderProduct = new Order_Product();
                    orderProduct.CurrentCost = product.Price;
                    orderProduct.Order_ref = currentOrder.OrderId;
                    orderProduct.Product_ref = product.ProductId;
                    db.data.Order_Product.Add(orderProduct);

                    
                    totalSum += product.Price;
                }

                db.data.SaveChanges();

                currentOrder.TotalPrice = totalSum;
                db.data.Entry(currentOrder).State = EntityState.Modified;
                db.data.SaveChanges();

                if (IsCustomerInSystemCheckBox.Checked)
                {
                    currentOrder.Customer_ref = Int32.Parse(CustomerIdTextBox.Text);
                    Customer customer = db.data.Customers.Find(currentOrder.Customer_ref);
                    customer.AccountSum += currentOrder.TotalPrice;
                    db.data.Entry(customer).State = EntityState.Modified;
                    db.data.SaveChanges();
                }
                productsList = new List<Product>();
                productsList.AddRange(db.data.Products.Where(p => p.IsAvaliable));
                dataGridView1.DataSource = productsList;
                dataGridView1.Refresh();
                MessageBox.Show("Товар був успішно проданий.");
            }
        }

        private void IsCustomerInSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsCustomerInSystemCheckBox.Checked)
            {
                CustomerIdTextBox.Enabled = true;
            }
            else
            {
                CustomerIdTextBox.Enabled = false;
            }
        }
    }
}
