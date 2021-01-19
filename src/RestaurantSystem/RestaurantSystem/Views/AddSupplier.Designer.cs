namespace RestaurantSystem.Views
{
    partial class AddSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.supplierAvailableDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.suppliersList = new System.Windows.Forms.ListBox();
            this.editSupplier = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на доставчик:";
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(576, 15);
            this.supplierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(215, 22);
            this.supplierName.TabIndex = 1;
            // 
            // supplierAvailableDays
            // 
            this.supplierAvailableDays.Location = new System.Drawing.Point(576, 148);
            this.supplierAvailableDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierAvailableDays.Name = "supplierAvailableDays";
            this.supplierAvailableDays.Size = new System.Drawing.Size(215, 22);
            this.supplierAvailableDays.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Свободни дни:";
            // 
            // supplierPhone
            // 
            this.supplierPhone.Location = new System.Drawing.Point(576, 81);
            this.supplierPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierPhone.Name = "supplierPhone";
            this.supplierPhone.Size = new System.Drawing.Size(215, 22);
            this.supplierPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефонен номер:";
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.Location = new System.Drawing.Point(681, 208);
            this.addSupplierButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(212, 47);
            this.addSupplierButton.TabIndex = 6;
            this.addSupplierButton.Text = "Добави доставчик";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // suppliersList
            // 
            this.suppliersList.FormattingEnabled = true;
            this.suppliersList.ItemHeight = 16;
            this.suppliersList.Location = new System.Drawing.Point(16, 15);
            this.suppliersList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suppliersList.Name = "suppliersList";
            this.suppliersList.Size = new System.Drawing.Size(339, 324);
            this.suppliersList.TabIndex = 8;
            // 
            // editSupplier
            // 
            this.editSupplier.Location = new System.Drawing.Point(392, 208);
            this.editSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editSupplier.Name = "editSupplier";
            this.editSupplier.Size = new System.Drawing.Size(212, 47);
            this.editSupplier.TabIndex = 9;
            this.editSupplier.Text = "Редактирай доствчик";
            this.editSupplier.UseVisualStyleBackColor = true;
            this.editSupplier.Click += new System.EventHandler(this.editSupplier_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(813, 369);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(115, 27);
            this.close.TabIndex = 10;
            this.close.Text = "Затвори";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Име на доставчик/телефон/свободни дни за доставка";
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.close);
            this.Controls.Add(this.editSupplier);
            this.Controls.Add(this.suppliersList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addSupplierButton);
            this.Controls.Add(this.supplierPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplierAvailableDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSupplier";
            this.Text = "Добави доставчик";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.TextBox supplierAvailableDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox suppliersList;
        private System.Windows.Forms.Button editSupplier;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label5;
    }
}