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
            label30.Visible = false;
        }

        private string expensesValidation()
        {
            string validation = "";
            try
            {
                if (year.Text.Length != 4 || months.SelectedItem == null)
                {
                    label30.Visible = true;
                    label30.Text = "Моля въведете валидни данни за година/месец.";
                    return "f";
                }
                else
                {
                    int yearr = int.Parse(year.Text);
                    if (electricity.Text != "")
                    {
                        double eValue = double.Parse(electricity.Text);
                        validation += "e";
                    }
                    if (water.Text != "")
                    {
                        double wValue = double.Parse(water.Text);
                        validation += "w";
                    }
                    if (internet.Text != "")
                    {
                        double iValue = double.Parse(internet.Text);
                        validation += "i";
                    }
                    return validation;
                }
            }
            catch (FormatException)
            {
                label30.Visible = true;
                label30.Text = "Моля въведете валидни данни.";
                return "f";
            }
            catch (OverflowException)
            {
                label30.Visible = true;
                label30.Text = "Моля въведете валидни данни.";
                return "f";
            }
            
        }

        private void AccountingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addExpense_Click(object sender, EventArgs e)
        {
            string dateString = year.Text + months.SelectedItem.ToString() + "00T00:00:00Z";
            double iValue = double.Parse(electricity.Text);
        }
    }
}
