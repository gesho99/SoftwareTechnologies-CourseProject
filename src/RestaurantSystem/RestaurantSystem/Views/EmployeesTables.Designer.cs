namespace RestaurantSystem.Views
{
    partial class EmployeesTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesTables));
            this.table = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.FlatAppearance.BorderSize = 0;
            this.table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table.Image = ((System.Drawing.Image)(resources.GetObject("table.Image")));
            this.table.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.table.Location = new System.Drawing.Point(68, 30);
            this.table.Margin = new System.Windows.Forms.Padding(2);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(89, 130);
            this.table.TabIndex = 10;
            this.table.Text = "Маси";
            this.table.UseVisualStyleBackColor = false;
            this.table.Click += new System.EventHandler(this.Table_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(138, 155);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeesTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 190);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeesTables";
            this.Text = "Маси";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button table;
        private System.Windows.Forms.Button backBtn;
    }
}