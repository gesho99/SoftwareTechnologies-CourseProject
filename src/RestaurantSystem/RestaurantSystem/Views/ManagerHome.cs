using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantSystem.Controllers;

namespace RestaurantSystem
{
    public partial class HomeAdmin : Form
    {
        DBController controller;

        public HomeAdmin(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            new Tables().Show();
            this.Hide();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            new AddUser(controller).Show();
            this.Hide();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            
            new Employees(controller).Show();
            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
          
             new Menu(controller).Show();
             this.Hide();

        }

        private void Stock_Click(object sender, EventArgs e)
        {

            new ProductsInStockForm(controller).Visible = true;
            this.Hide();
        }

        private void Delivery_Click(object sender, EventArgs e)
        {
            new Deliveries(controller).Show();
            this.Hide();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            new AccountingForm(controller).Show();
            this.Hide();
        }
    }
}
