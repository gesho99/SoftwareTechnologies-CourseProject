using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.Views
{
    public partial class EmployeesTables : Form
    {
        public EmployeesTables()
        {
            InitializeComponent();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            //new Tables().Show();
            this.Hide();
        }
    }
}
