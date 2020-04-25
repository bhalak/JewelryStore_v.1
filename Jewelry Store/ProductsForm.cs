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

    public partial class ProductsForm : Form
    {
       
        public ProductsForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            db.data.Products.Load();
            dataGridView1.DataSource = db.data.Products.Local.ToBindingList();

        }

        private void showComponents()
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
            Product product = db.data.Products.Find(id);
            ComponentsListBox.Items.Clear();
            List<string> componentsList = new List<string>();

            var componentProductJoin = from prod_com  in  db.data.Product_Component 
                join prod in db.data.Products on prod_com.Product_ref equals  prod.ProductId
                join com in db.data.Components on prod_com.Component_ref equals com.ComponentId
                where prod.ProductId == product.ProductId
                select new
                {
                    Mass = prod_com.PartMass,
                    Name = com.PartName
                };
            foreach (var a in componentProductJoin)
            {
                componentsList.Add(a.Name + " - " + a.Mass);
            }

            ComponentsListBox.Items.AddRange(componentsList.ToArray());

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

        private void countStoreProductCost(int storeId)
        {
            Store store = db.data.Stores.Find(storeId);
            store.TotalProductCost = db.data.Products.Where(p => p.Store_ref == store.ObjectId && p.IsAvaliable).Sum(p => p.Price);
            db.data.Entry(store).State = EntityState.Modified;
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

                Product product = db.data.Products.Find(id);

                if (db.data.Order_Product.Any(p => p.Product_ref == product.ProductId))
                {
                    MessageBox.Show("Даний продукт був проданий і знаходиться в таблиці 'Замовлення'," +
                                    " тому його не можна видалити зі списку");
                    return;
                }

                int store_ref = Int32.Parse(product.Store_ref.ToString());

                db.data.Product_Component.RemoveRange(db.data.Product_Component
                    .Where(pc => pc.Product_ref == product.ProductId));
                db.data.Products.Remove(product);

                db.data.SaveChanges();
                dataGridView1.Refresh();

                countStoreProductCost(store_ref);
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showComponents();
        }

        private void initializeComboBoxes()
        {
            for (int i = 0; i < 10; i++)
            {
                GlobalInfo.constituents[i].comboBox.DataSource = db.data.Components.ToList();
                GlobalInfo.constituents[i].comboBox.ValueMember = "ComponentId";
                GlobalInfo.constituents[i].comboBox.DisplayMember = "PartName";           
            }
        }

        private bool checkMassEntered()
        {
            for (int i = 0; i < Constituents.numComponents; i++)
            {
                if (GlobalInfo.constituents[i].textBox.Text.Trim() == "")
                {
                    return false;
                }
            }

            return true;
        }

        private bool checkUniqueness()
        {
            var list = GlobalInfo.constituents.Select(c => Int32.Parse(c.comboBox.SelectedValue.ToString())).ToList();
            for (int i = 0; i < Constituents.numComponents - 1; i++)
            {
                if (Contain(list, i + 1, Constituents.numComponents,
                    Int32.Parse(GlobalInfo.constituents[i].comboBox.SelectedValue.ToString()) ))
                {
                    return false;
                }
            }

            return true;
        }

        private bool Contain(List<int> list, int start, int end, int lookingForId)
        {
            for (int i = start; i < end; i++)
            {
                if (list[i] == lookingForId)
                {
                    return true;
                }
            }

            return false;
        }

        private bool checkMassFloat()
        {
            for (int i = 0; i < Constituents.numComponents; i++)
            {
                if (!float.TryParse(GlobalInfo.constituents[i].textBox.Text, out float n))
                {
                    return false;
                }
            }

            return true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
  
            var newProductForm = new NewProductForm();
            initializeComboBoxes();
            newProductForm.TypeComboBox.DataSource = db.data.Types.ToList();
            newProductForm.TypeComboBox.ValueMember = "TypeId";
            newProductForm.TypeComboBox.DisplayMember = "TypeName";

            do
            {
                DialogResult result = newProductForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (newProductForm.PriceTextBox.Text.Trim() == "" ||
                    newProductForm.StoreIdTextBox.Text.Trim() == "" ||
                    !checkMassEntered())
                {
                    MessageBox.Show("Усі поля повинні бути заповнені!");
                    continue;
                }
                else if(!checkUniqueness())
                {
                    MessageBox.Show("Усі компоненти повинні бути різного виду!");
                    continue;
                }
                else if(!Int32.TryParse(newProductForm.StoreIdTextBox.Text.Trim(), out int n) )
                {
                    MessageBox.Show("Неправильний формат Id магазину. Id повонине бути числом.");
                    continue;
                }

                int StoreId = Int32.Parse(newProductForm.StoreIdTextBox.Text );
                if (db.data.Stores.Where(s=>s.ObjectId == StoreId).Count() == 0)
                {
                    MessageBox.Show("Tакого Id магазину не існує, спробуйте інше");
                }
                else if(!float.TryParse(newProductForm.PriceTextBox.Text, out float n))
                {
                    MessageBox.Show("Неправильно вказана ціна товару. Ціна повинн бути числом.");
                }
                else if(!checkMassFloat())
                {
                    MessageBox.Show("Непраильно вказана маса складника. Маса повинна бути числом.");
                }
                else
                {
                    break;
                }
            } while (true);

            Product newProduct = new Product();

            newProduct.Price = decimal.Parse(newProductForm.PriceTextBox.Text);
            newProduct.Store_ref = Int32.Parse(newProductForm.StoreIdTextBox.Text);
            newProduct.IsAvaliable = newProductForm.IsAvaibleCheckBox.Checked;
            newProduct.Type_ref = Int32.Parse(newProductForm.TypeComboBox.SelectedValue.ToString() );
            newProduct.TotalMass = getProductMass();

            db.data.Products.Add(newProduct);

            Product_Component prod_com;

            for (int i = 0; i < Constituents.numComponents; i++)
            {
                prod_com = new Product_Component();

                prod_com.Product_ref = newProduct.ProductId;
                prod_com.Component_ref = Int32.Parse(GlobalInfo.constituents[i].comboBox.SelectedValue.ToString());
                prod_com.PartMass = decimal.Parse(GlobalInfo.constituents[i].textBox.Text);

                db.data.Product_Component.Add(prod_com);
            }

            db.data.SaveChanges();

            countStoreProductCost(Int32.Parse(newProduct.Store_ref.ToString()));
        }

        private decimal getProductMass()
        {
            decimal ProductMass = 0;

            for (int i = 0; i < Constituents.numComponents; i++)
            {
                ProductMass += decimal.Parse(GlobalInfo.constituents[i].textBox.Text);
            }

            return ProductMass;
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

                Product newProduct = db.data.Products.Find(id);
                var newProductForm = new NewProductForm();

                if (!newProduct.IsAvaliable)
                {
                    if (db.data.Order_Product.Any(op => op.Product_ref == newProduct.ProductId))
                    {
                        newProductForm.IsAvaibleCheckBox.Enabled = false;
                    }
                }

                initializeComboBoxes();
                newProductForm.TypeComboBox.DataSource = db.data.Types.ToList();
                newProductForm.TypeComboBox.ValueMember = "TypeId";
                newProductForm.TypeComboBox.DisplayMember = "TypeName";

                newProductForm.PriceTextBox.Text = newProduct.Price.ToString();
                newProductForm.StoreIdTextBox.Text = newProduct.Store_ref.ToString();
                newProductForm.IsAvaibleCheckBox.Checked = newProduct.IsAvaliable;
                newProductForm.TypeComboBox.SelectedValue = newProduct.Type_ref;

                addComponentsOnForm(newProductForm, newProduct);

                do
                {
                    DialogResult result = newProductForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }

                    if (newProductForm.PriceTextBox.Text.Trim() == "" ||
                        newProductForm.StoreIdTextBox.Text.Trim() == "" ||
                        !checkMassEntered())
                    {
                        MessageBox.Show("Усі поля повинні бути заповнені!");
                        continue;
                    }
                    else if (!checkUniqueness())
                    {
                        MessageBox.Show("Усі компоненти повинні бути різного виду!");
                        continue;
                    }
                    else if (!Int32.TryParse(newProductForm.StoreIdTextBox.Text.Trim(), out int n))
                    {
                        MessageBox.Show("Неправильний формат Id магазину. Id повонине бути числом.");
                        continue;
                    }

                    int StoreId = Int32.Parse(newProductForm.StoreIdTextBox.Text);
                    if (db.data.Stores.Where(s => s.ObjectId == StoreId).Count() == 0)
                    {
                        MessageBox.Show("Tакого Id магазину не існує, спробуйте інше");
                    }
                    else if (!float.TryParse(newProductForm.PriceTextBox.Text, out float n))
                    {
                        MessageBox.Show("Неправильно вказана ціна товару. Ціна повинн бути числом.");
                    }
                    else if (!checkMassFloat())
                    {
                        MessageBox.Show("Непраильно вказана маса складника. Маса повинна бути числом.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);


                db.data.Product_Component.RemoveRange(db.data.Product_Component
                    .Where(pc => pc.Product_ref == newProduct.ProductId));

                newProduct.Price = decimal.Parse(newProductForm.PriceTextBox.Text);
                newProduct.Store_ref = Int32.Parse(newProductForm.StoreIdTextBox.Text);
                newProduct.IsAvaliable = newProductForm.IsAvaibleCheckBox.Checked;
                newProduct.Type_ref = Int32.Parse(newProductForm.TypeComboBox.SelectedValue.ToString());
                newProduct.TotalMass = getProductMass();

                db.data.Entry(newProduct).State = EntityState.Modified;

                Product_Component prod_com;

                for (int i = 0; i < Constituents.numComponents; i++)
                {
                    prod_com = new Product_Component();

                    prod_com.Product_ref = newProduct.ProductId;
                    prod_com.Component_ref = Int32.Parse(GlobalInfo.constituents[i].comboBox.SelectedValue.ToString());
                    prod_com.PartMass = decimal.Parse(GlobalInfo.constituents[i].textBox.Text);

                    db.data.Product_Component.Add(prod_com);
                }

                db.data.SaveChanges();
                dataGridView1.Refresh();

                countStoreProductCost(Int32.Parse(newProduct.Store_ref.ToString()));
            }
        }

        private void addComponentsOnForm(NewProductForm newProductForm, Product product)
        {
            List<int> comboBoxValues = db.data.Product_Component.Where(pc => pc.Product_ref == product.ProductId)
                .Select(pc => pc.Component_ref).ToList();
            List<decimal> componentsMass = db.data.Product_Component.Where(pc => pc.Product_ref == product.ProductId)
                .Select(pc => pc.PartMass).ToList();

            int numComponents = comboBoxValues.Count;

            GlobalInfo.constituents[0].comboBox.SelectedValue =
                comboBoxValues[0];
            GlobalInfo.constituents[0].textBox.Text =
                componentsMass[0].ToString();

            for (int i = 1; i < numComponents; i++)
            {
                GlobalInfo.constituents[i].componentLabel.Visible = true;
                GlobalInfo.constituents[i].comboBox.Visible = true;
                GlobalInfo.constituents[i].massLabel.Visible = true;
                GlobalInfo.constituents[i].textBox.Visible = true;

                GlobalInfo.constituents[i].comboBox.SelectedValue =
                    comboBoxValues[i];
                GlobalInfo.constituents[i].textBox.Text =
                    componentsMass[i].ToString();

                newProductForm.deleteComponentButton.Visible = true;
                newProductForm.deleteComponentButton.Location =
                    new Point(newProductForm.deleteComponentButton.Location.X,
                        GlobalInfo.constituents[i].textBox.Location.Y);

                newProductForm.AddComponent.Location = new Point(newProductForm.AddComponent.Location.X,
                    GlobalInfo.constituents[i].textBox.Location.Y + 40);

                newProductForm.Add_OK_btn.Location = new Point(newProductForm.Add_OK_btn.Location.X,
                    newProductForm.AddComponent.Location.Y + 40);
                newProductForm.Add_Cancel_btn.Location = new Point(newProductForm.Add_Cancel_btn.Location.X,
                    newProductForm.AddComponent.Location.Y + 40);
                newProductForm.groupBox.Size = new Size(newProductForm.groupBox.Width,
                    newProductForm.Add_Cancel_btn.Location.Y + 40);
                newProductForm.Size = new Size(newProductForm.Size.Width, newProductForm.groupBox.Size.Height + 40);

                ++Constituents.numComponents;
                if (Constituents.numComponents == 10)
                {
                    newProductForm.AddComponent.Visible = false;
                }
            }
        }
    }
}
