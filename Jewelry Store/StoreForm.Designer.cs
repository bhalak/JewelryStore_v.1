namespace Jewelry_Store
{
    partial class StoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.AlertBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.objectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Головне меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlertBtn
            // 
            this.AlertBtn.Location = new System.Drawing.Point(250, 380);
            this.AlertBtn.Name = "AlertBtn";
            this.AlertBtn.Size = new System.Drawing.Size(131, 35);
            this.AlertBtn.TabIndex = 21;
            this.AlertBtn.Text = "Редагувати дані";
            this.AlertBtn.UseVisualStyleBackColor = true;
            this.AlertBtn.Click += new System.EventHandler(this.AlertBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(135, 380);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(87, 35);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(21, 380);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(85, 35);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Видалити";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(757, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectIdDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.numOfStreetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.locationBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.locationBindingSource2.DataSource = typeof(Jewelry_Store.Location);
            // 
            // locationBindingSource1
            // 
            this.locationBindingSource1.DataSource = typeof(Jewelry_Store.Location);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(Jewelry_Store.Location);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlertBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазини";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AlertBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource locationBindingSource1;
        private System.Windows.Forms.BindingSource locationBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}