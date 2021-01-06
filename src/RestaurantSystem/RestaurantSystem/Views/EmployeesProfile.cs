using RestaurantSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class Employees : Form
    {
        DBController controller;
        public Employees(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new HomeAdmin(controller).Show();
            this.Hide();
        }
    }
}
