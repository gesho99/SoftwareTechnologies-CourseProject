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
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addDelivery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // approvedDeliveries
            // 
            this.approvedDeliveries.FormattingEnabled = true;
            this.approvedDeliveries.HorizontalScrollbar = true;
            this.approvedDeliveries.Location = new System.Drawing.Point(242, 43);
            this.approvedDeliveries.Name = "approvedDeliveries";
            this.approvedDeliveries.Size = new System.Drawing.Size(338, 251);
            this.approvedDeliveries.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Одобрени доставки:";
            // 
            // approveDeliveryButton
            // 
            this.approveDeliveryButton.Location = new System.Drawing.Point(35, 210);
            this.approveDeliveryButton.Name = "approveDeliveryButton";
            this.approveDeliveryButton.Size = new System.Drawing.Size(160, 35);
            this.approveDeliveryButton.TabIndex = 2;
            this.approveDeliveryButton.Text = "Одобри доставка";
            this.approveDeliveryButton.UseVisualStyleBackColor = true;
            this.approveDeliveryButton.Click += new System.EventHandler(this.approveDeliveryButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Продукт:";
            // 
            // DeliveryQuantity
            // 
            this.DeliveryQuantity.AutoSize = true;
            this.DeliveryQuantity.Location = new System.Drawing.Point(287, 45);
            this.DeliveryQuantity.Name = "DeliveryQuantity";
            this.DeliveryQuantity.Size = new System.Drawing.Size(135, 13);
            this.DeliveryQuantity.TabIndex = 5;
            this.DeliveryQuantity.Text = "Количество за добавяне:";
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(278, 64);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(160, 20);
            this.productQuantity.TabIndex = 7;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(35, 64);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(160, 20);
            this.productName.TabIndex = 8;
            // 
            // waitingDeliveries
            // 
            this.waitingDeliveries.FormattingEnabled = true;
            this.waitingDeliveries.HorizontalScrollbar = true;
            this.waitingDeliveries.Location = new System.Drawing.Point(6, 43);
            this.waitingDeliveries.Name = "waitingDeliveries";
            this.waitingDeliveries.Size = new System.Drawing.Size(230, 251);
            this.waitingDeliveries.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Чакащи доставки:\r\n";
            // 
            // editDelivery
            // 
            this.editDelivery.Location = new System.Drawing.Point(278, 158);
            this.editDelivery.Name = "editDelivery";
            this.editDelivery.Size = new System.Drawing.Size(160, 35);
            this.editDelivery.TabIndex = 13;
            this.editDelivery.Text = "Промени доставка";
            this.editDelivery.UseVisualStyleBackColor = true;
            this.editDelivery.Click += new System.EventHandler(this.editDelivery_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(278, 45);
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
            this.label6.Location = new System.Drawing.Point(32, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(34, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "*";
            // 
            // deliverySupplier
            // 
            this.deliverySupplier.Location = new System.Drawing.Point(35, 117);
            this.deliverySupplier.Name = "deliverySupplier";
            this.deliverySupplier.Size = new System.Drawing.Size(160, 20);
            this.deliverySupplier.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Доставчик:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.waitingDeliveries);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.approvedDeliveries);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 319);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "име на доставчик/количество на доставка/цена/продукт-количество след доставка";
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
            this.groupBox3.Controls.Add(this.addDelivery);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.deliverySupplier);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.editDelivery);
            this.groupBox3.Controls.Add(this.productName);
            this.groupBox3.Controls.Add(this.productQuantity);
            this.groupBox3.Controls.Add(this.DeliveryQuantity);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.approveDeliveryButton);
            this.groupBox3.Location = new System.Drawing.Point(22, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 262);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Одобрение/промяна на доставка";
            // 
            // addDelivery
            // 
            this.addDelivery.Location = new System.Drawing.Point(35, 158);
            this.addDelivery.Name = "addDelivery";
            this.addDelivery.Size = new System.Drawing.Size(160, 35);
            this.addDelivery.TabIndex = 29;
            this.addDelivery.Text = "Направи доставка";
            this.addDelivery.UseVisualStyleBackColor = true;
            this.addDelivery.Click += new System.EventHandler(this.addDelivery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addDelivery;
    }
}