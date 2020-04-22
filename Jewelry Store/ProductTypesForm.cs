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
    public partial class PtoductTypesForm : Form
    {
        public PtoductTypesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            db.data.Types.Load();
            dataGridView1.DataSource = db.data.Types.Local.ToBindingList();
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

                Type newType = db.data.Types.Find(id);
                
                var newTypeForm = new NewTypeForm();
                newTypeForm.TypeNameTextBox.Text = newType.TypeName;
                do
                {
                    DialogResult result = newTypeForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }

                    if (newTypeForm.TypeNameTextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Усі поля повинні бути заповнені!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

 
                newType.TypeName = newTypeForm.TypeNameTextBox.Text;

                db.data.Entry(newType).State = EntityState.Modified;
                db.data.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newTypeForm = new NewTypeForm();
            do
            {
                DialogResult result = newTypeForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (newTypeForm.TypeNameTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Усі поля повинні бути заповнені!");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            Type newType = new Type();
            newType.TypeName = newTypeForm.TypeNameTextBox.Text;

            db.data.Types.Add(newType);
            db.data.SaveChanges();
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

                Type type = db.data.Types.Find(id);

                int numProducts = db.data.Products.Count(p => p.Type_ref == type.TypeId);
                if (numProducts > 0)
                {
                    MessageBox.Show("Неможливо виконати видалення, " +
                                    "оскільки в базі даних існує товар вибраного типу.");
                    return;
                }

                db.data.Types.Remove(type);
                db.data.SaveChanges();
                dataGridView1.Refresh();
            }
        }
    }
}
