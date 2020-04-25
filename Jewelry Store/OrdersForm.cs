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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            db.data.Orders.Load();
            dataGridView1.DataSource = db.data.Orders.Local.ToBindingList();
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showProducts();
        }

        private void showProducts()
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;

            Order order = db.data.Orders.Find(id);
            ProductsListBox.Items.Clear();

            List<string> productsList = new List<string>();

            var orderProductsJoin = from ord_prod in db.data.Order_Product
                join prod in db.data.Products on ord_prod.Product_ref equals prod.ProductId
                join ord in db.data.Orders on ord_prod.Order_ref equals ord.OrderId
                where ord.OrderId == order.OrderId
                select new
                {
                    id = prod.ProductId,
                    type = prod.Type.TypeName,
                    price = ord_prod.CurrentCost
                };

            foreach (var i in orderProductsJoin)
            {
                productsList.Add($"id({i.id}) {i.type} - {i.price}");
            }

            ProductsListBox.Items.AddRange(productsList.ToArray());
        }

    }
}
