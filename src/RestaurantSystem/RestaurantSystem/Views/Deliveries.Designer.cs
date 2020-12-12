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
            this.label8 = new System.Windows.Forms.Label();
            this.deliveryPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deliverySupplier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // approvedDeliveries
            // 
            this.approvedDeliveries.FormattingEnabled = true;
            this.approvedDeliveries.Location = new System.Drawing.Point(262, 43);
            this.approvedDeliveries.Name = "approvedDeliveries";
            this.approvedDeliveries.Size = new System.Drawing.Size(253, 251);
            this.approvedDeliveries.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Одобрени доставки:";
            // 
            // approveDeliveryButton
            // 
            this.approveDeliveryButton.Location = new System.Drawing.Point(56, 159);
            this.approveDeliveryButton.Name = "approveDeliveryButton";
            this.approveDeliveryButton.Size = new System.Drawing.Size(160, 48);
            this.approveDeliveryButton.TabIndex = 2;
            this.approveDeliveryButton.Text = "Одобри поръчка";
            this.approveDeliveryButton.UseVisualStyleBackColor = true;
            this.approveDeliveryButton.Click += new System.EventHandler(this.approveDeliveryButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Продукт:";
            // 
            // DeliveryQuantity
            // 
            this.DeliveryQuantity.AutoSize = true;
            this.DeliveryQuantity.Location = new System.Drawing.Point(295, 46);
            this.DeliveryQuantity.Name = "DeliveryQuantity";
            this.DeliveryQuantity.Size = new System.Drawing.Size(69, 13);
            this.DeliveryQuantity.TabIndex = 5;
            this.DeliveryQuantity.Text = "Количество:";
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(286, 65);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(160, 20);
            this.productQuantity.TabIndex = 7;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(56, 65);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(160, 20);
            this.productName.TabIndex = 8;
            // 
            // waitingDeliveries
            // 
            this.waitingDeliveries.FormattingEnabled = true;
            this.waitingDeliveries.Location = new System.Drawing.Point(12, 43);
            this.waitingDeliveries.Name = "waitingDeliveries";
            this.waitingDeliveries.Size = new System.Drawing.Size(253, 251);
            this.waitingDeliveries.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Чакащи доставка:";
            // 
            // editDelivery
            // 
            this.editDelivery.Location = new System.Drawing.Point(286, 159);
            this.editDelivery.Name = "editDelivery";
            this.editDelivery.Size = new System.Drawing.Size(160, 48);
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
            this.label7.Location = new System.Drawing.Point(286, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(53, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(53, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "*";
            // 
            // deliveryPrice
            // 
            this.deliveryPrice.Location = new System.Drawing.Point(56, 116);
            this.deliveryPrice.Name = "deliveryPrice";
            this.deliveryPrice.Size = new System.Drawing.Size(160, 20);
            this.deliveryPrice.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Цена на доставка:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(285, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "*";
            // 
            // deliverySupplier
            // 
            this.deliverySupplier.Location = new System.Drawing.Point(286, 116);
            this.deliverySupplier.Name = "deliverySupplier";
            this.deliverySupplier.Size = new System.Drawing.Size(160, 20);
            this.deliverySupplier.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Доставчик:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.waitingDeliveries);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.approvedDeliveries);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 319);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 231);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.deliverySupplier);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.deliveryPrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.editDelivery);
            this.groupBox3.Controls.Add(this.productName);
            this.groupBox3.Controls.Add(this.productQuantity);
            this.groupBox3.Controls.Add(this.DeliveryQuantity);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.approveDeliveryButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 262);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Одобрение/промяна на доставка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(451, 595);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(77, 23);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 630);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Deliveries";
            this.Text = "Доставки";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox deliveryPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox deliverySupplier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
    }
}