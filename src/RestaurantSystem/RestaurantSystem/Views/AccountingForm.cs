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

                    if (electricity.Text == "" && water.Text == "" && internet.Text == "")
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
            MessageBox.Show(validation);
            if (validation != "f")
            {
                string dateString = year.Text + months.SelectedItem.ToString() + "01T00:00:00Z";

                if (validation.Contains("e"))
                {
                    double eValue = double.Parse(electricity.Text);
                    if (controller.AddElectricityExpense(dateString, eValue) == false)
                    {
                        label30.Visible = true;
                        label30.Text = "Въведеният разход " + electricity.Text + " за периода " + year.Text + "/" + months.SelectedItem.ToString() + " вече съществува.";
                        return;
                    }
                    else
                    {
                        label30.Visible = true;
                        label30.Text = "Въведеният разход " + electricity.Text + " за периода " + year.Text + "/" + months.SelectedItem.ToString() + " е успешно добавен";
                    }
                }

                if (validation.Contains("w"))
                {
                    double wValue = double.Parse(water.Text);
                    if (controller.AddWaterExpense(dateString, wValue) == false)
                    {
                        label30.Visible = true;
                        label30.Text = "Въведеният разход " + water.Text + " за периода " + year.Text + "/" + months.SelectedItem.ToString() + " вече съществува.";
                        return;
                    }
                    else
                    {
                        label30.Visible = true;
                        label30.Text = "Въведеният разход " + water.Text + " за периода " + year.Text + "/" + months.SelectedItem.ToString() + " е успешно добавен.";
                    }
                }

                if (validation.Contains("i"))
                {
                    double iValue = double.Parse(internet.Text);
                    if (!controller.AddInternetExpense(dateString, iValue) == false)
                    {
                        label30.Visible = true;
                        label30.Text = "Въведеният разход " + internet.Text + " за периода " + year.Text + "/" + months.SelectedItem.ToString() + " вече съществува.";
                        return;
                    }
                    else
                    {
                        label30.Visible = true;
                        label30.Text = "Въведеният разход " + internet.Text + " за периода " + year.Text + "/" + months.SelectedItem.ToString() + " е успешно добавен.";
                    }
                }

                label30.Visible = true;
                label30.Text = "Разходите за периода " + year.Text + "/" + months.SelectedItem.ToString() + " са успешно добавени.";
            }
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
                if (expenses.Count != 0)
                {
                    foreach(Expenses expense in expenses)
                    {
                        if(expense.Name == "Ток")
                        {
                            electricity.Text = expense.Value.ToString();
                        }
                        else if (expense.Name == "Вода")
                        {
                            water.Text = expense.Value.ToString();
                        }
                        else if (expense.Name == "Интернет")
                        {
                            internet.Text = expense.Value.ToString();
                        }
                    }
                }
                else
                {
                    label30.Visible = true;
                    label30.Text = "Няма добавени разходи за периода " + year.Text + "/" + months.SelectedItem.ToString();
                }
            }
        }
    }
}
