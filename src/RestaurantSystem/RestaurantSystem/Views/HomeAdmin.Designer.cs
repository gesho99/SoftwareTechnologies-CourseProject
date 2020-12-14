namespace RestaurantSystem
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.addUser = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.delivery = new System.Windows.Forms.Button();
            this.accounting = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addUser.Location = new System.Drawing.Point(1, 1);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(147, 253);
            this.addUser.TabIndex = 4;
            this.addUser.Text = "Добави нов потребител";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.Transparent;
            this.employees.FlatAppearance.BorderSize = 0;
            this.employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees.Image = ((System.Drawing.Image)(resources.GetObject("employees.Image")));
            this.employees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.employees.Location = new System.Drawing.Point(222, 1);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(116, 243);
            this.employees.TabIndex = 7;
            this.employees.Text = "Служители";
            this.employees.UseVisualStyleBackColor = false;
            this.employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.FlatAppearance.BorderSize = 0;
            this.table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table.Image = ((System.Drawing.Image)(resources.GetObject("table.Image")));
            this.table.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.table.Location = new System.Drawing.Point(422, 16);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(156, 223);
            this.table.TabIndex = 9;
            this.table.Text = "Маси";
            this.table.UseVisualStyleBackColor = false;
            this.table.Click += new System.EventHandler(this.Table_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu.Location = new System.Drawing.Point(626, 42);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(137, 171);
            this.menu.TabIndex = 10;
            this.menu.Text = "Меню";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // delivery
            // 
            this.delivery.BackColor = System.Drawing.Color.Transparent;
            this.delivery.FlatAppearance.BorderSize = 0;
            this.delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery.Image = ((System.Drawing.Image)(resources.GetObject("delivery.Image")));
            this.delivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delivery.Location = new System.Drawing.Point(335, 206);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(99, 232);
            this.delivery.TabIndex = 11;
            this.delivery.Text = "Доставки";
            this.delivery.UseVisualStyleBackColor = false;
            this.delivery.Click += new System.EventHandler(this.Delivery_Click);
            // 
            // accounting
            // 
            this.accounting.BackColor = System.Drawing.Color.Transparent;
            this.accounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.accounting.FlatAppearance.BorderSize = 0;
            this.accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accounting.Image = ((System.Drawing.Image)(resources.GetObject("accounting.Image")));
            this.accounting.Location = new System.Drawing.Point(565, 191);
            this.accounting.Name = "accounting";
            this.accounting.Size = new System.Drawing.Size(111, 144);
            this.accounting.TabIndex = 12;
            this.accounting.Text = "Счетоводство";
            this.accounting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accounting.UseVisualStyleBackColor = false;
            this.accounting.Click += new System.EventHandler(this.Accounting_Click);
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.Transparent;
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.Image = ((System.Drawing.Image)(resources.GetObject("stock.Image")));
            this.stock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stock.Location = new System.Drawing.Point(87, 206);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(99, 232);
            this.stock.TabIndex = 13;
            this.stock.Text = "Наличност";
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.accounting);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.table);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.addUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button table;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button delivery;
        private System.Windows.Forms.Button accounting;
        private System.Windows.Forms.Button stock;
    }
}