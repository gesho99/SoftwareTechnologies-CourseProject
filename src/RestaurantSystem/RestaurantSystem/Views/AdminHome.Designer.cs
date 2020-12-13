namespace LoginForm
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.accounting = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.delivery = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accounting
            // 
            this.accounting.BackColor = System.Drawing.Color.Transparent;
            this.accounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.accounting.FlatAppearance.BorderSize = 0;
            this.accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accounting.Image = ((System.Drawing.Image)(resources.GetObject("accounting.Image")));
            this.accounting.Location = new System.Drawing.Point(772, 297);
            this.accounting.Name = "accounting";
            this.accounting.Size = new System.Drawing.Size(111, 144);
            this.accounting.TabIndex = 1;
            this.accounting.Text = "Счетоводство";
            this.accounting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accounting.UseVisualStyleBackColor = false;
            this.accounting.Click += new System.EventHandler(this.Button1_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addUser.Location = new System.Drawing.Point(12, 34);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(99, 232);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Добави нов потребител";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // delivery
            // 
            this.delivery.BackColor = System.Drawing.Color.Transparent;
            this.delivery.FlatAppearance.BorderSize = 0;
            this.delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery.Image = ((System.Drawing.Image)(resources.GetObject("delivery.Image")));
            this.delivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delivery.Location = new System.Drawing.Point(412, 312);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(99, 232);
            this.delivery.TabIndex = 4;
            this.delivery.Text = "Доставки";
            this.delivery.UseVisualStyleBackColor = false;
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.Transparent;
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.Image = ((System.Drawing.Image)(resources.GetObject("stock.Image")));
            this.stock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stock.Location = new System.Drawing.Point(123, 312);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(99, 232);
            this.stock.TabIndex = 5;
            this.stock.Text = "Наличност";
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.Transparent;
            this.employees.FlatAppearance.BorderSize = 0;
            this.employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees.Image = ((System.Drawing.Image)(resources.GetObject("employees.Image")));
            this.employees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.employees.Location = new System.Drawing.Point(265, 51);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(116, 215);
            this.employees.TabIndex = 6;
            this.employees.Text = "Служители";
            this.employees.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu.Location = new System.Drawing.Point(671, 76);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(137, 149);
            this.menu.TabIndex = 7;
            this.menu.Text = "Меню";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.FlatAppearance.BorderSize = 0;
            this.table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table.Image = ((System.Drawing.Image)(resources.GetObject("table.Image")));
            this.table.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.table.Location = new System.Drawing.Point(460, 70);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(119, 160);
            this.table.TabIndex = 8;
            this.table.Text = "Маси";
            this.table.UseVisualStyleBackColor = false;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 611);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.accounting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accounting;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button delivery;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button table;
    }
}