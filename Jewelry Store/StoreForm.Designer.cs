using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Jewelry_Store
{
    partial class StoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            this.button1 = new Button();
            this.AlertBtn = new Button();
            this.AddBtn = new Button();
            this.DeleteBtn = new Button();
            this.label3 = new Label();
            this.dataGridView1 = new DataGridView();
            this.objectIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.numOfStreetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.locationBindingSource2 = new BindingSource(this.components);
            this.locationBindingSource1 = new BindingSource(this.components);
            this.locationBindingSource = new BindingSource(this.components);
            ((ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((ISupportInitialize)(this.locationBindingSource2)).BeginInit();
            ((ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            ((ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new Point(640, 444);
            this.button1.Name = "button1";
            this.button1.Size = new Size(132, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Головне меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // AlertBtn
            // 
            this.AlertBtn.Location = new Point(250, 380);
            this.AlertBtn.Name = "AlertBtn";
            this.AlertBtn.Size = new Size(131, 35);
            this.AlertBtn.TabIndex = 21;
            this.AlertBtn.Text = "Редагувати дані";
            this.AlertBtn.UseVisualStyleBackColor = true;
            this.AlertBtn.Click += new EventHandler(this.AlertBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new Point(135, 380);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new Size(87, 35);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new Point(21, 380);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new Size(85, 35);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Видалити";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new EventHandler(this.DeleteBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = Color.Maroon;
            this.label3.Cursor = Cursors.Hand;
            this.label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = SystemColors.ButtonHighlight;
            this.label3.Location = new Point(757, -1);
            this.label3.Name = "label3";
            this.label3.Size = new Size(42, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "x";
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            this.label3.Click += new EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            this.objectIdDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.numOfStreetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.locationBindingSource2;
            this.dataGridView1.Location = new Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new Size(760, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // objectIdDataGridViewTextBoxColumn
            // 
            this.objectIdDataGridViewTextBoxColumn.DataPropertyName = "ObjectId";
            this.objectIdDataGridViewTextBoxColumn.HeaderText = "ObjectId";
            this.objectIdDataGridViewTextBoxColumn.Name = "objectIdDataGridViewTextBoxColumn";
            // 
            // storeDataGridViewTextBoxColumn
            // 
            this.storeDataGridViewTextBoxColumn.DataPropertyName = "Store";
            this.storeDataGridViewTextBoxColumn.HeaderText = "Сумарна вартість товарів";
            this.storeDataGridViewTextBoxColumn.Name = "storeDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Вулиця";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // numOfStreetDataGridViewTextBoxColumn
            // 
            this.numOfStreetDataGridViewTextBoxColumn.DataPropertyName = "NumOfStreet";
            this.numOfStreetDataGridViewTextBoxColumn.HeaderText = "Номер вулиці";
            this.numOfStreetDataGridViewTextBoxColumn.Name = "numOfStreetDataGridViewTextBoxColumn";
            // 
            // locationBindingSource2
            // 
            this.locationBindingSource2.DataSource = typeof(Location);
            // 
            // locationBindingSource1
            // 
            this.locationBindingSource1.DataSource = typeof(Location);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(Location);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlertBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StoreForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Магазини";
            ((ISupportInitialize)(this.dataGridView1)).EndInit();
            ((ISupportInitialize)(this.locationBindingSource2)).EndInit();
            ((ISupportInitialize)(this.locationBindingSource1)).EndInit();
            ((ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource locationBindingSource;
        private Button button1;
        private Button AlertBtn;
        private Button AddBtn;
        private Button DeleteBtn;
        private Label label3;
        private BindingSource locationBindingSource1;
        private BindingSource locationBindingSource2;
        private DataGridViewTextBoxColumn numOfStreetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn objectIdDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
    }
}