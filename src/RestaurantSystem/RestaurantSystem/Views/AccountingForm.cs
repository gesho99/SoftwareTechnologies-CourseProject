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
    public partial class AccountingForm : Form
    {

        Controller controller;

        public AccountingForm(Controller controller)
        {
            this.controller = controller;
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

                    if(electricity.Text == "" && water.Text == "" && internet.Text == "")
                    {
                        label30.Visible = true;
                        label30.Text = "Моля въведете поне един разход.";
                        return "f";
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
            string validation = expensesValidation();
            if (validation != "f")
            {
                string dateString = year.Text + months.SelectedItem.ToString() + "01T00:00:00Z";

                if (validation.Contains("e"))
                {
                    double eValue = double.Parse(electricity.Text);
                    controller.AddElectricityExpense(dateString, eValue);
                }

                if (validation.Contains("w"))
                {
                    double wValue = double.Parse(water.Text);
                    controller.AddWaterExpense(dateString, wValue);
                }

                if (validation.Contains("i"))
                {
                    double iValue = double.Parse(internet.Text);
                    controller.AddInternetExpense(dateString, iValue);
                }

                label30.Visible = true;
                label30.Text = "Разходите за периода " + year.Text + "/" + months.SelectedItem.ToString() + " са успешно добавени.";
            }
        }
    }
}
