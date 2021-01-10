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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.accounting = new System.Windows.Forms.Button();
            this.delivery = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(260, 1055);
            this.panelMenu.TabIndex = 14;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant System";
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
=======
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addUser.Location = new System.Drawing.Point(1, 1);
            this.addUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(110, 206);
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
            this.employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees.ForeColor = System.Drawing.Color.Gainsboro;
            this.employees.Image = ((System.Drawing.Image)(resources.GetObject("employees.Image")));
            this.employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employees.Location = new System.Drawing.Point(-3, 170);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(260, 93);
=======
            this.employees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.employees.Location = new System.Drawing.Point(166, 1);
            this.employees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(87, 197);
            this.employees.TabIndex = 7;
            this.employees.Text = "Служители";
            this.employees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employees.UseVisualStyleBackColor = false;
            this.employees.Click += new System.EventHandler(this.Employees_Click);
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
=======
            this.table.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.table.Location = new System.Drawing.Point(316, 13);
            this.table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(117, 181);
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
=======
            this.menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menu.Location = new System.Drawing.Point(470, 34);
            this.menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(103, 139);
            this.menu.TabIndex = 10;
            this.menu.Text = "Меню";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(260, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1322, 80);
            this.panelTitleBar.TabIndex = 14;
=======
            this.delivery.BackColor = System.Drawing.Color.Transparent;
            this.delivery.FlatAppearance.BorderSize = 0;
            this.delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery.Image = ((System.Drawing.Image)(resources.GetObject("delivery.Image")));
            this.delivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delivery.Location = new System.Drawing.Point(251, 167);
            this.delivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(74, 188);
            this.delivery.TabIndex = 11;
            this.delivery.Text = "Доставки";
            this.delivery.UseVisualStyleBackColor = false;
            this.delivery.Click += new System.EventHandler(this.Delivery_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1149, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
=======
            this.accounting.BackColor = System.Drawing.Color.Transparent;
            this.accounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.accounting.FlatAppearance.BorderSize = 0;
            this.accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accounting.Image = ((System.Drawing.Image)(resources.GetObject("accounting.Image")));
            this.accounting.Location = new System.Drawing.Point(424, 155);
            this.accounting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accounting.Name = "accounting";
            this.accounting.Size = new System.Drawing.Size(83, 117);
            this.accounting.TabIndex = 12;
            this.accounting.Text = "Счетоводство";
            this.accounting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accounting.UseVisualStyleBackColor = false;
            this.accounting.Click += new System.EventHandler(this.Accounting_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1184, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 29);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1219, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 51);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(34, 29);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(615, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "НАЧАЛО";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.ForeColor = System.Drawing.Color.Transparent;
            this.panelDesktopPanel.Location = new System.Drawing.Point(260, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1322, 975);
            this.panelDesktopPanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantSystem.Properties.Resources.onlinelogomaker_010721_1136_4394_2000_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
=======
            this.stock.BackColor = System.Drawing.Color.Transparent;
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.Image = ((System.Drawing.Image)(resources.GetObject("stock.Image")));
            this.stock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stock.Location = new System.Drawing.Point(65, 167);
            this.stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(74, 188);
            this.stock.TabIndex = 13;
            this.stock.Text = "Наличност";
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "ManagerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
=======
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.accounting);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.table);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.addUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerHome";
            this.Text = "HomeAdmin";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}