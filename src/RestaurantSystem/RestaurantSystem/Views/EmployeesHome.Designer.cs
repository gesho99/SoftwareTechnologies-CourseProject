namespace RestaurantSystem
{
    partial class EmployeesHome
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
            this.profileBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.tablesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profileBtn
            // 
            this.profileBtn.Location = new System.Drawing.Point(12, 26);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 23);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "Профил";
            this.profileBtn.UseVisualStyleBackColor = true;
            // 
            // menuBtn
            // 
            this.menuBtn.Location = new System.Drawing.Point(12, 93);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(75, 23);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.Text = "Меню";
            this.menuBtn.UseVisualStyleBackColor = true;
            // 
            // tablesBtn
            // 
            this.tablesBtn.Location = new System.Drawing.Point(12, 148);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(75, 23);
            this.tablesBtn.TabIndex = 2;
            this.tablesBtn.Text = "Маси";
            this.tablesBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeesHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tablesBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.profileBtn);
            this.Name = "EmployeesHome";
            this.Text = "EmployeesHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button tablesBtn;
    }
}