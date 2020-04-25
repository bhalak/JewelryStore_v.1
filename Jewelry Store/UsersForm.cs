using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Store
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();

            db.data.Users.Load();
            dataGridView1.DataSource = db.data.Users.Local.ToBindingList();
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


                User user = db.data.Users.Find(id);

                db.data.Users.Remove(user);

                db.data.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newUserForm = new NewUserForm();
            newUserForm.LevelAccesComboBox.DataSource = db.data.Rules.ToList();
            newUserForm.LevelAccesComboBox.ValueMember = "RuleId";
            newUserForm.LevelAccesComboBox.DisplayMember = "LevelAccess";
            int numUsers;
            do
            {


                DialogResult result = newUserForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (newUserForm.LoginTextBox.Text.Trim() == "" ||
                    newUserForm.FullNameTextBox.Text.Trim() == "" ||
                    newUserForm.PasswordTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Усі поля повинні бути заповнені!");
                    continue;
                }

                string newLogin = newUserForm.LoginTextBox.Text;

                numUsers = db.data.Users.Where(u => u.Login == newLogin).Count();
                if (numUsers == 1)
                {
                    MessageBox.Show("Такий логін вже існує! Спробуйте інший.");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            User newUser = new User();
            newUser.Login = newUserForm.LoginTextBox.Text;
            newUser.Password = newUserForm.PasswordTextBox.Text;
            newUser.Rule_ref = Int32.Parse(newUserForm.LevelAccesComboBox.SelectedValue.ToString());
            newUser.FullName = newUserForm.FullNameTextBox.Text;


            db.data.Users.Add(newUser);
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

                User user = db.data.Users.Find(id);
                var newUserForm = new NewUserForm();
                newUserForm.LevelAccesComboBox.DataSource = db.data.Rules.ToList();
                newUserForm.LevelAccesComboBox.ValueMember = "RuleId";
                newUserForm.LevelAccesComboBox.DisplayMember = "LevelAccess";

                newUserForm.LoginTextBox.Text = user.Login;
                newUserForm.PasswordTextBox.Text = user.Password;
                newUserForm.LevelAccesComboBox.SelectedValue= user.Rule.RuleId;
                newUserForm.FullNameTextBox.Text = user.FullName;


                int numUsers;
                do
                {


                    DialogResult result = newUserForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }

                    if (newUserForm.LoginTextBox.Text.Trim() == "" ||
                        newUserForm.FullNameTextBox.Text.Trim() == "" ||
                        newUserForm.PasswordTextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Усі поля повинні бути заповнені!");
                        continue;
                    }

                    string newLogin = newUserForm.LoginTextBox.Text;

                    numUsers = db.data.Users.Where(u => u.Login == newLogin && u.UserId != user.UserId).Count();
                    if (numUsers == 1)
                    {
                        MessageBox.Show("Такий логін вже існує! Спробуйте інший.");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                } while (true);

                user.Login = newUserForm.LoginTextBox.Text;
                user.Password = newUserForm.PasswordTextBox.Text;
                user.Rule_ref = Int32.Parse(newUserForm.LevelAccesComboBox.SelectedValue.ToString());
                user.FullName = newUserForm.FullNameTextBox.Text;

                db.data.Entry(user).State = EntityState.Modified;
                try
                {

                    db.data.SaveChanges();

                }
                catch (DbEntityValidationException ex)
                {
                    string exepiton="";
                    foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                    {
                        exepiton += "Object: " + validationError.Entry.Entity.ToString();
                        exepiton += "\n\n";
                        Console.WriteLine("");
                        foreach (DbValidationError err in validationError.ValidationErrors)
                        {
                            exepiton += err.ErrorMessage + "";
                        }
                    }

                    MessageBox.Show(exepiton);
                }

                dataGridView1.Refresh();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            GlobalInfo.mainWindow.Show();
            this.Close();
        }
    }
}
