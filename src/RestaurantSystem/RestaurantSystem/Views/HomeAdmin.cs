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
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            new Tables().Show();
            this.Hide();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            new AddUser().Show();
            this.Hide();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            
            new Employees().Show();
            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
          
               // new Menu().Show();
                this.Hide();

                }

            private void Stock_Click(object sender, EventArgs e)
        {

            //new ProductsInStockForm().Visible = true
            this.Hide();
        }

        private void Delivery_Click(object sender, EventArgs e)
        {
            new Deliveries().Show();
            this.Hide();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            new AccountingForm().Show();
            this.Hide();
        }
    }
}
