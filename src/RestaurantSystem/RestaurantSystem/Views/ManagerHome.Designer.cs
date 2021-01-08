namespace RestaurantSystem
{
    partial class ManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHome));
            this.addUser = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.delivery = new System.Windows.Forms.Button();
            this.accounting = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.employees = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addUser.Location = new System.Drawing.Point(-3, 71);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(260, 100);
            this.addUser.TabIndex = 4;
            this.addUser.Text = "Добави нов потребител";
            this.addUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.FlatAppearance.BorderSize = 0;
            this.table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.ForeColor = System.Drawing.Color.Gainsboro;
            this.table.Image = ((System.Drawing.Image)(resources.GetObject("table.Image")));
            this.table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.table.Location = new System.Drawing.Point(3, 269);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(260, 93);
            this.table.TabIndex = 9;
            this.table.Text = "Маси";
            this.table.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.table.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.table.UseVisualStyleBackColor = false;
            this.table.Click += new System.EventHandler(this.Table_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.Gainsboro;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(0, 356);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(260, 93);
            this.menu.TabIndex = 10;
            this.menu.Text = "Меню";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // delivery
            // 
            this.delivery.BackColor = System.Drawing.Color.Transparent;
            this.delivery.FlatAppearance.BorderSize = 0;
            this.delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.ForeColor = System.Drawing.Color.Gainsboro;
            this.delivery.Image = ((System.Drawing.Image)(resources.GetObject("delivery.Image")));
            this.delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delivery.Location = new System.Drawing.Point(3, 547);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(260, 93);
            this.delivery.TabIndex = 11;
            this.delivery.Text = "Доставки";
            this.delivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delivery.UseVisualStyleBackColor = false;
            this.delivery.Click += new System.EventHandler(this.Delivery_Click);
            // 
            // accounting
            // 
            this.accounting.BackColor = System.Drawing.Color.Transparent;
            this.accounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.accounting.FlatAppearance.BorderSize = 0;
            this.accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accounting.ForeColor = System.Drawing.Color.Gainsboro;
            this.accounting.Image = ((System.Drawing.Image)(resources.GetObject("accounting.Image")));
            this.accounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accounting.Location = new System.Drawing.Point(3, 646);
            this.accounting.Name = "accounting";
            this.accounting.Size = new System.Drawing.Size(260, 93);
            this.accounting.TabIndex = 12;
            this.accounting.Text = "Счетоводство";
            this.accounting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accounting.UseVisualStyleBackColor = false;
            this.accounting.Click += new System.EventHandler(this.Accounting_Click);
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.Transparent;
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.Gainsboro;
            this.stock.Image = ((System.Drawing.Image)(resources.GetObject("stock.Image")));
            this.stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock.Location = new System.Drawing.Point(3, 438);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(260, 93);
            this.stock.TabIndex = 13;
            this.stock.Text = "Наличност";
            this.stock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.accounting);
            this.panelMenu.Controls.Add(this.delivery);
            this.panelMenu.Controls.Add(this.stock);
            this.panelMenu.Controls.Add(this.employees);
            this.panelMenu.Controls.Add(this.addUser);
            this.panelMenu.Controls.Add(this.table);
            this.panelMenu.Controls.Add(this.menu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 753);
            this.panelMenu.TabIndex = 14;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.Transparent;
            this.employees.FlatAppearance.BorderSize = 0;
            this.employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees.ForeColor = System.Drawing.Color.Gainsboro;
            this.employees.Image = ((System.Drawing.Image)(resources.GetObject("employees.Image")));
            this.employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employees.Location = new System.Drawing.Point(-3, 170);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(260, 93);
            this.employees.TabIndex = 7;
            this.employees.Text = "Служители";
            this.employees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employees.UseVisualStyleBackColor = false;
            this.employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerHome";
            this.Text = "HomeAdmin";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button table;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button delivery;
        private System.Windows.Forms.Button accounting;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button employees;
    }
}