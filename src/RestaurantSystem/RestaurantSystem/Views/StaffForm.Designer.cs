namespace LoginForm
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.table = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.FlatAppearance.BorderSize = 0;
            this.table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table.Image = ((System.Drawing.Image)(resources.GetObject("table.Image")));
            this.table.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.table.Location = new System.Drawing.Point(134, 28);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(119, 160);
            this.table.TabIndex = 9;
            this.table.Text = "Маси";
            this.table.UseVisualStyleBackColor = false;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 210);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button table;
    }
}