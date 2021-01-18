namespace RestaurantSystem.Views
{
    partial class ManagerTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerTables));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billBtn = new System.Windows.Forms.Button();
            this.billTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productsList = new System.Windows.Forms.RichTextBox();
            this.tableNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteTableBtn = new System.Windows.Forms.Button();
            this.tablesCombo = new System.Windows.Forms.ComboBox();
            this.tablesAddBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.billBtn);
            this.groupBox1.Controls.Add(this.billTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.productsList);
            this.groupBox1.Controls.Add(this.tableNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(661, 683);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Избрана маса";
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(108, 49);
            this.dateTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(64, 22);
            this.dateTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата:";
            // 
            // billBtn
            // 
            this.billBtn.Location = new System.Drawing.Point(348, 433);
            this.billBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(148, 46);
            this.billBtn.TabIndex = 10;
            this.billBtn.Text = "Издай касов бон";
            this.billBtn.UseVisualStyleBackColor = true;
            // 
            // billTxt
            // 
            this.billTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billTxt.Location = new System.Drawing.Point(333, 373);
            this.billTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billTxt.Name = "billTxt";
            this.billTxt.Size = new System.Drawing.Size(147, 34);
            this.billTxt.TabIndex = 4;
            this.billTxt.Text = "0";
            this.billTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(177, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Обща сума:";
            // 
            // productsList
            // 
            this.productsList.Location = new System.Drawing.Point(27, 107);
            this.productsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(468, 248);
            this.productsList.TabIndex = 2;
            this.productsList.Text = "";
            // 
            // tableNum
            // 
            this.tableNum.Location = new System.Drawing.Point(431, 49);
            this.tableNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableNum.Name = "tableNum";
            this.tableNum.ReadOnly = true;
            this.tableNum.Size = new System.Drawing.Size(64, 22);
            this.tableNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(237, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Избрана маса:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteTableBtn);
            this.groupBox4.Controls.Add(this.tablesCombo);
            this.groupBox4.Controls.Add(this.tablesAddBtn);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(718, 26);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(536, 200);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Маси";
            // 
            // deleteTableBtn
            // 
            this.deleteTableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTableBtn.Location = new System.Drawing.Point(268, 76);
            this.deleteTableBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteTableBtn.Name = "deleteTableBtn";
            this.deleteTableBtn.Size = new System.Drawing.Size(207, 39);
            this.deleteTableBtn.TabIndex = 7;
            this.deleteTableBtn.Text = "Изтрий маса";
            this.deleteTableBtn.UseVisualStyleBackColor = true;
            // 
            // tablesCombo
            // 
            this.tablesCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesCombo.FormattingEnabled = true;
            this.tablesCombo.Location = new System.Drawing.Point(20, 39);
            this.tablesCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablesCombo.Name = "tablesCombo";
            this.tablesCombo.Size = new System.Drawing.Size(205, 37);
            this.tablesCombo.TabIndex = 6;
            // 
            // tablesAddBtn
            // 
            this.tablesAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesAddBtn.Location = new System.Drawing.Point(268, 30);
            this.tablesAddBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablesAddBtn.Name = "tablesAddBtn";
            this.tablesAddBtn.Size = new System.Drawing.Size(201, 39);
            this.tablesAddBtn.TabIndex = 5;
            this.tablesAddBtn.Text = "Добави маса";
            this.tablesAddBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.priceTxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addItem);
            this.groupBox3.Controls.Add(this.itemsList);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(718, 260);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(536, 500);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавяне на продукт";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(255, 95);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(191, 34);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена:";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxt.Location = new System.Drawing.Point(255, 162);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(189, 34);
            this.priceTxt.TabIndex = 12;
            this.priceTxt.Text = "\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Продукти:";
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addItem.Location = new System.Drawing.Point(297, 228);
            this.addItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(148, 46);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Добави";
            this.addItem.UseVisualStyleBackColor = true;
            // 
            // itemsList
            // 
            this.itemsList.DisplayMember = "DishCategory";
            this.itemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(255, 23);
            this.itemsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(189, 37);
            this.itemsList.TabIndex = 0;
            this.itemsList.ValueMember = "DishCategory";
            // 
            // ManagerTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerTables";
            this.Text = "Маси";
            this.Load += new System.EventHandler(this.ManagerTables_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox productsList;
        private System.Windows.Forms.TextBox tableNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.TextBox billTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteTableBtn;
        private System.Windows.Forms.ComboBox tablesCombo;
        private System.Windows.Forms.Button tablesAddBtn;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.ComboBox itemsList;
    }
}