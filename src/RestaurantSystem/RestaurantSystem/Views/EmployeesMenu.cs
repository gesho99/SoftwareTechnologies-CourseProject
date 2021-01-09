using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class EmployeesMenu : Form
    {
        public EmployeesMenu()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
           
            label2.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
            domainUpDown1.ForeColor = ThemeColor.SecondaryColor;
           

        }

        private void EmployeesMenu_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
