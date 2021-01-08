namespace RestaurantSystem
{
    partial class Deliveries
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
            this.approvedDeliveries = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.approveDeliveryButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeliveryQuantity = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.waitingDeliveries = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editDelivery = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deliverySupplier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.approvedQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // approvedDeliveries
            // 
            this.approvedDeliveries.FormattingEnabled = true;
            this.approvedDeliveries.HorizontalScrollbar = true;
            this.approvedDeliveries.ItemHeight = 16;
            this.approvedDeliveries.Location = new System.Drawing.Point(323, 53);
            this.approvedDeliveries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approvedDeliveries.Name = "approvedDeliveries";
            this.approvedDeliveries.Size = new System.Drawing.Size(305, 308);
            this.approvedDeliveries.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Одобрени доставки:";
            // 
            // approveDeliveryButton
            // 
            this.approveDeliveryButton.Location = new System.Drawing.Point(47, 194);
            this.approveDeliveryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approveDeliveryButton.Name = "approveDeliveryButton";
            this.approveDeliveryButton.Size = new System.Drawing.Size(213, 59);
            this.approveDeliveryButton.TabIndex = 2;
            this.approveDeliveryButton.Text = "Одобри поръчка";
            this.approveDeliveryButton.UseVisualStyleBackColor = true;
            this.approveDeliveryButton.Click += new System.EventHandler(this.approveDeliveryButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Продукт:";
            // 
            // DeliveryQuantity
            // 
            this.DeliveryQuantity.AutoSize = true;
            this.DeliveryQuantity.Location = new System.Drawing.Point(383, 55);
            this.DeliveryQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeliveryQuantity.Name = "DeliveryQuantity";
            this.DeliveryQuantity.Size = new System.Drawing.Size(111, 17);
            this.DeliveryQuantity.TabIndex = 5;
            this.DeliveryQuantity.Text = "Количество +/-:";
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(371, 79);
            this.productQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(212, 22);
            this.productQuantity.TabIndex = 7;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(47, 79);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(212, 22);
            this.productName.TabIndex = 8;
            // 
            // waitingDeliveries
            // 
            this.waitingDeliveries.FormattingEnabled = true;
            this.waitingDeliveries.HorizontalScrollbar = true;
            this.waitingDeliveries.ItemHeight = 16;
            this.waitingDeliveries.Location = new System.Drawing.Point(8, 53);
            this.waitingDeliveries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waitingDeliveries.Name = "waitingDeliveries";
            this.waitingDeliveries.Size = new System.Drawing.Size(305, 308);
            this.waitingDeliveries.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Чакащи доставка:\r\n";
            // 
            // editDelivery
            // 
            this.editDelivery.Location = new System.Drawing.Point(371, 194);
            this.editDelivery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editDelivery.Name = "editDelivery";
            this.editDelivery.Size = new System.Drawing.Size(213, 59);
            this.editDelivery.TabIndex = 13;
            this.editDelivery.Text = "Промени поръчка";
            this.editDelivery.UseVisualStyleBackColor = true;
            this.editDelivery.Click += new System.EventHandler(this.editDelivery_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(371, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(43, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(45, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "*";
            // 
            // deliverySupplier
            // 
            this.deliverySupplier.Location = new System.Drawing.Point(47, 144);
            this.deliverySupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliverySupplier.Name = "deliverySupplier";
            this.deliverySupplier.Size = new System.Drawing.Size(212, 22);
            this.deliverySupplier.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Доставчик:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.waitingDeliveries);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.approvedDeliveries);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(652, 393);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "продукт - количество/количество/цена на доставката/име на доставчик";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 391);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(696, 284);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.approvedQuantity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.deliverySupplier);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.editDelivery);
            this.groupBox3.Controls.Add(this.productName);
            this.groupBox3.Controls.Add(this.productQuantity);
            this.groupBox3.Controls.Add(this.DeliveryQuantity);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.approveDeliveryButton);
            this.groupBox3.Location = new System.Drawing.Point(16, 402);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(653, 322);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Одобрение/промяна на доставка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(367, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "*";
            // 
            // approvedQuantity
            // 
            this.approvedQuantity.Location = new System.Drawing.Point(371, 144);
            this.approvedQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approvedQuantity.Name = "approvedQuantity";
            this.approvedQuantity.Size = new System.Drawing.Size(212, 22);
            this.approvedQuantity.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Одобрено количество :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(13, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 24;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(544, 732);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 28);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 775);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Deliveries";
            this.Text = "Доставки";
            this.Load += new System.EventHandler(this.Deliveries_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox approvedDeliveries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button approveDeliveryButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DeliveryQuantity;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.ListBox waitingDeliveries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editDelivery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox deliverySupplier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox approvedQuantity;
        private System.Windows.Forms.Label label9;
    }
}