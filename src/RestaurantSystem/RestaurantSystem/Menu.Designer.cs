﻿namespace RestaurantSystem
{
    partial class Menu
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
            this.menuItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuItemsParameters = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addMenuItem = new System.Windows.Forms.Button();
            this.editMenuItem = new System.Windows.Forms.Button();
            this.deleteMenuItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItems
            // 
            this.menuItems.FormattingEnabled = true;
            this.menuItems.Location = new System.Drawing.Point(12, 25);
            this.menuItems.Name = "menuItems";
            this.menuItems.Size = new System.Drawing.Size(149, 290);
            this.menuItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продукти в менюто:";
            // 
            // menuItemsParameters
            // 
            this.menuItemsParameters.FormattingEnabled = true;
            this.menuItemsParameters.Location = new System.Drawing.Point(158, 25);
            this.menuItemsParameters.Name = "menuItemsParameters";
            this.menuItemsParameters.Size = new System.Drawing.Size(278, 290);
            this.menuItemsParameters.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Име/цена/компоненти/тегло:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.menuItemsParameters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.menuItems);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 327);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(35, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Име на продукт:";
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(24, 40);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(141, 20);
            this.itemName.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(36, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(45, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Тегло на продукт:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(36, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(45, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Цена на продукт:";
            // 
            // itemPrice
            // 
            this.itemPrice.Location = new System.Drawing.Point(24, 97);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(141, 20);
            this.itemPrice.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Компоненти в продукт:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteMenuItem);
            this.groupBox2.Controls.Add(this.editMenuItem);
            this.groupBox2.Controls.Add(this.addMenuItem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.itemPrice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.itemName);
            this.groupBox2.Location = new System.Drawing.Point(504, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 327);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // addMenuItem
            // 
            this.addMenuItem.Location = new System.Drawing.Point(205, 40);
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(141, 39);
            this.addMenuItem.TabIndex = 41;
            this.addMenuItem.Text = "Добави нов продукт";
            this.addMenuItem.UseVisualStyleBackColor = true;
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Location = new System.Drawing.Point(205, 120);
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(141, 39);
            this.editMenuItem.TabIndex = 42;
            this.editMenuItem.Text = "Редактирай продукт";
            this.editMenuItem.UseVisualStyleBackColor = true;
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Location = new System.Drawing.Point(205, 206);
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(141, 39);
            this.deleteMenuItem.TabIndex = 43;
            this.deleteMenuItem.Text = "Изтрий продукт";
            this.deleteMenuItem.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Меню";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox menuItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox menuItemsParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteMenuItem;
        private System.Windows.Forms.Button editMenuItem;
        private System.Windows.Forms.Button addMenuItem;
    }
}