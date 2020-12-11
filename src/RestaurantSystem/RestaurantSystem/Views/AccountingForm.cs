using RestaurantSystem.Controllers;
using RestaurantSystem.Data.Models;
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
    public partial class AccountingForm : Form
    {
        public AccountingForm()
        {
            InitializeComponent();
        }

        private void seeExpenses_Click(object sender, EventArgs e)
        {
            electricity.Text = "";
            water.Text = "";
            internet.Text = "";

            if (year.Text.Length != 4 || months.SelectedItem == null)
            {
                label30.Visible = true;
                label30.Text = "Моля въведете валидни данни за година/месец.";
            }
            else
            {
                string dateString = year.Text + months.SelectedItem.ToString() + "01T00:00:00Z";
                List<Expenses> expenses = controller.GetExpenses(dateString);
                electricity.Text = expenses.Find(ex => ex.Name == "Ток").Value.ToString();
                water.Text = expenses.Find(ex => ex.Name == "Вода").Value.ToString();
                internet.Text = expenses.Find(ex => ex.Name == "Интернет").Value.ToString();
            }
        }
    }
}
