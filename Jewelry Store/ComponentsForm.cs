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
    public partial class ComponentsForm : Form
    {
        public ComponentsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            db.data.Components.Load();
            dataGridView1.DataSource = db.data.Components.Local.ToBindingList();
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
            var newComponentForm = new NewComponentForm();

            do
            {
                DialogResult result = newComponentForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (newComponentForm.ComponentNameTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Усі поля повинні бути заповнені!");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            Component newComponent = new Component();
            newComponent.PartName = newComponentForm.ComponentNameTextBox.Text;

            db.data.Components.Add(newComponent);
            db.data.SaveChanges();
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

                Component newComponent = db.data.Components.Find(id);

                var newComponentForm = new NewComponentForm();
                newComponentForm.ComponentNameTextBox.Text = newComponent.PartName;

                do
                {
                    DialogResult result = newComponentForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }

                    if (newComponentForm.ComponentNameTextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Усі поля повинні бути заповнені!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                newComponent.PartName = newComponentForm.ComponentNameTextBox.Text;

                db.data.Entry(newComponent).State = EntityState.Modified;
                db.data.SaveChanges();
                dataGridView1.Refresh();
            }
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

                Component component = db.data.Components.Find(id);

                int numProducts = db.data.Product_Component
                    .Count(p_c=>p_c.Component_ref == component.ComponentId);
                if (numProducts > 0)
                {
                    MessageBox.Show("Неможливо виконати видалення, оскільки в базі даних " +
                                    "існує товар який містить вибрану компоненту.");
                    return;
                }

                db.data.Components.Remove(component);
                db.data.SaveChanges();
                dataGridView1.Refresh();
            }
        }
    }
}
