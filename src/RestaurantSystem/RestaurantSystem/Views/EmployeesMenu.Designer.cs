namespace RestaurantSystem
{
    partial class EmployeesMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishSellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dishNameDataGridViewTextBoxColumn,
            this.dishSellingPriceDataGridViewTextBoxColumn,
            this.dishWeightDataGridViewTextBoxColumn,
            this.dishProductsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dishBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(RestaurantSystem.Data.Models.Dish);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishNameDataGridViewTextBoxColumn
            // 
            this.dishNameDataGridViewTextBoxColumn.DataPropertyName = "DishName";
            this.dishNameDataGridViewTextBoxColumn.HeaderText = "DishName";
            this.dishNameDataGridViewTextBoxColumn.Name = "dishNameDataGridViewTextBoxColumn";
            this.dishNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishSellingPriceDataGridViewTextBoxColumn
            // 
            this.dishSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "DishSellingPrice";
            this.dishSellingPriceDataGridViewTextBoxColumn.HeaderText = "DishSellingPrice";
            this.dishSellingPriceDataGridViewTextBoxColumn.Name = "dishSellingPriceDataGridViewTextBoxColumn";
            this.dishSellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishWeightDataGridViewTextBoxColumn
            // 
            this.dishWeightDataGridViewTextBoxColumn.DataPropertyName = "DishWeight";
            this.dishWeightDataGridViewTextBoxColumn.HeaderText = "DishWeight";
            this.dishWeightDataGridViewTextBoxColumn.Name = "dishWeightDataGridViewTextBoxColumn";
            this.dishWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishProductsDataGridViewTextBoxColumn
            // 
            this.dishProductsDataGridViewTextBoxColumn.DataPropertyName = "DishProducts";
            this.dishProductsDataGridViewTextBoxColumn.HeaderText = "DishProducts";
            this.dishProductsDataGridViewTextBoxColumn.Name = "dishProductsDataGridViewTextBoxColumn";
            this.dishProductsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmployeesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeesMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.EmployeesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishSellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dishBindingSource;
    }
}