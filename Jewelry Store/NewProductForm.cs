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
    public partial class NewProductForm : Form
    {

        public NewProductForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
            PriceTextBox.MaxLength = 12;
            StoreIdTextBox.MaxLength = 8;
            PartMassTextBox.MaxLength = 12;
            textBox1.MaxLength = 12;
            textBox2.MaxLength = 12;
            textBox3.MaxLength = 12;
            textBox4.MaxLength = 12;
            textBox5.MaxLength = 12;
            textBox6.MaxLength = 12;
            textBox7.MaxLength = 12;
            textBox8.MaxLength = 12;
            textBox9.MaxLength = 12;
            GlobalInfo.constituents = new List<Constituents>();
            Constituents.numComponents = 1;

            CreatComponentField();
        }

        internal void CreatComponentField()
        {
            GlobalInfo.constituents.Add(new Constituents(label1, ComponentsComboBox, label11, PartMassTextBox));
            GlobalInfo.constituents.Add(new Constituents(label3, comboBox1, label2, textBox1));
            GlobalInfo.constituents.Add(new Constituents(label5, comboBox2, label4, textBox2));
            GlobalInfo.constituents.Add(new Constituents(label7, comboBox3, label6, textBox3));
            GlobalInfo.constituents.Add(new Constituents(label9, comboBox4, label8, textBox4));
            GlobalInfo.constituents.Add(new Constituents(label12, comboBox5, label10, textBox5));
            GlobalInfo.constituents.Add(new Constituents(label14, comboBox6, label13, textBox6));
            GlobalInfo.constituents.Add(new Constituents(label16, comboBox7, label15, textBox7));
            GlobalInfo.constituents.Add(new Constituents(label18, comboBox8, label17, textBox8));
            GlobalInfo.constituents.Add(new Constituents(label20, comboBox9, label19, textBox9));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddComponent_Click(object sender, EventArgs e)
        {
            GlobalInfo.constituents[Constituents.numComponents].componentLabel.Visible = true;
            GlobalInfo.constituents[Constituents.numComponents].comboBox.Visible = true;
            GlobalInfo.constituents[Constituents.numComponents].massLabel.Visible = true;
            GlobalInfo.constituents[Constituents.numComponents].textBox.Visible = true;
            deleteComponentButton.Visible = true;
            deleteComponentButton.Location =
                new Point(deleteComponentButton.Location.X, GlobalInfo.constituents[Constituents.numComponents].textBox.Location.Y);

            AddComponent.Location = new Point(AddComponent.Location.X, GlobalInfo.constituents[Constituents.numComponents].textBox.Location.Y + 40);

            Add_OK_btn.Location = new Point(Add_OK_btn.Location.X, AddComponent.Location.Y + 40);
            Add_Cancel_btn.Location = new Point(Add_Cancel_btn.Location.X, AddComponent.Location.Y + 40);
            groupBox.Size = new Size(groupBox.Width, Add_Cancel_btn.Location.Y + 40);
            this.Size = new Size(this.Size.Width, groupBox.Size.Height + 40);

            ++Constituents.numComponents;
            if (Constituents.numComponents == 10)
            {
                AddComponent.Visible = false;
            }
        }

        private void deleteComponentButton_Click(object sender, EventArgs e)
        {
            --Constituents.numComponents;

            if (Constituents.numComponents == 1)
            {
                deleteComponentButton.Visible = false;
            }

            if (Constituents.numComponents < 10)
            {
                AddComponent.Visible = true;
            }
            GlobalInfo.constituents[Constituents.numComponents].componentLabel.Visible = false;
            GlobalInfo.constituents[Constituents.numComponents].comboBox.Visible = false;
            GlobalInfo.constituents[Constituents.numComponents].massLabel.Visible = false;
            GlobalInfo.constituents[Constituents.numComponents].textBox.Visible = false;

            deleteComponentButton.Location =
                new Point(deleteComponentButton.Location.X, GlobalInfo.constituents[Constituents.numComponents - 1].textBox.Location.Y);

            AddComponent.Location = new Point(AddComponent.Location.X, GlobalInfo.constituents[Constituents.numComponents - 1].textBox.Location.Y + 40);

            Add_OK_btn.Location = new Point(Add_OK_btn.Location.X, AddComponent.Location.Y + 40);
            Add_Cancel_btn.Location = new Point(Add_Cancel_btn.Location.X, AddComponent.Location.Y + 40);
            groupBox.Size = new Size(groupBox.Width, Add_Cancel_btn.Location.Y + 40);
            this.Size = new Size(this.Size.Width, groupBox.Size.Height + 40);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
