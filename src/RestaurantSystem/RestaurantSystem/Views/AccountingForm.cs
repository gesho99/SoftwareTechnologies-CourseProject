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
        DBController controller;

        public AccountingForm(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LabelController.ChangeLabelVisibility(ref label30, false);
        }
        public AccountingForm()
        {

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label16.ForeColor = ThemeColor.SecondaryColor;

           
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            label10.ForeColor = ThemeColor.SecondaryColor;
            label11.ForeColor = ThemeColor.PrimaryColor;
            label12.ForeColor = ThemeColor.SecondaryColor;

            label17.ForeColor = ThemeColor.PrimaryColor;
            label18.ForeColor = ThemeColor.SecondaryColor;
            label19.ForeColor = ThemeColor.PrimaryColor;
            label26.ForeColor = ThemeColor.SecondaryColor;
            label32.ForeColor = ThemeColor.PrimaryColor;
            label23.ForeColor = ThemeColor.PrimaryColor;
            label24.ForeColor = ThemeColor.PrimaryColor;
            label25.ForeColor = ThemeColor.PrimaryColor;




        }
        private string expensesValidation()
        {
            string validation = "";
            try
            {
                if (year.Text.Length != 4 || months.SelectedItem == null)
                {
                    LabelController.ChangeLabelVisibility(ref label30, true);
                    LabelController.ChangeLabelText(ref label30, "Моля въведете валидни данни за година/месец.");
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
                        LabelController.ChangeLabelVisibility(ref label30, true);
                        LabelController.ChangeLabelText(ref label30, "Моля въведете поне един разход.");
                        return "f";
                    }

                    return validation;
                }
            }
            catch (FormatException)
            {
                LabelController.ChangeLabelVisibility(ref label30, true);
                LabelController.ChangeLabelText(ref label30, "Моля въведете валидни данни.");
                return "f";
            }
            catch (OverflowException)
            {
                LabelController.ChangeLabelVisibility(ref label30, true);
                LabelController.ChangeLabelText(ref label30, "Моля въведете валидни данни.");
                return "f";
            }

        }

        private double CalculateProfit(double incomes, double expenses)
        {
            return incomes - expenses;
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
                    if (FormToDBController.AddElectricityExpenseInDataBaseIfNotExists(ref controller, dateString, eValue) == false)
                    {
                        LabelController.ChangeLabelVisibility(ref label30, true);
                        LabelController.ChangeLabelText(ref label30, "Въведеният разход за ток " + 
                                                        electricity.Text + " за периода " + 
                                                        year.Text + "/" + 
                                                        months.SelectedItem.ToString() + " вече съществува.");
                        return;
                    }
                    else
                    {
                        LabelController.ChangeLabelVisibility(ref label30, true);
                        LabelController.ChangeLabelText(ref label30, "Въведеният разход за ток " + 
                                                        electricity.Text + " за периода " + 
                                                        year.Text + "/" + 
                                                        months.SelectedItem.ToString() + " е успешно добавен");
                    }
                }

                if (validation.Contains("w"))
                {
                    double wValue = double.Parse(water.Text);
                    if (FormToDBController.AddWaterExpenseInDataBaseIfNotExists(ref controller, dateString, wValue) == false)
                    {
                        LabelController.ChangeLabelVisibility(ref label30, true);
                        LabelController.ChangeLabelText(ref label30, "Въведеният разход за вода " + 
                                                        water.Text + " за периода " + 
                                                        year.Text + "/" + 
                                                        months.SelectedItem.ToString() + " вече съществува.");
                        return;
                    }
                    else
                    {
                        LabelController.ChangeLabelVisibility(ref label30, true);
                        LabelController.ChangeLabelText(ref label30, "Въведеният разход за вода " + 
                                                        water.Text + " за периода " + 
                                                        year.Text + "/" + 
                                                        months.SelectedItem.ToString() + " е успешно добавен.");
                    }
                }

                if (validation.Contains("i"))
                {
                    double iValue = double.Parse(internet.Text);
                    if (FormToDBController.AddInternetExpenseInDataBaseIfNotExists(ref controller, dateString, iValue) == false)
                    {
                        LabelController.ChangeLabelVisibility(ref label30, true);
                        LabelController.ChangeLabelText(ref label30, "Въведеният разход за интернет " + 
                                                        internet.Text + " за периода " + 
                                                        year.Text + "/" + 
                                                        months.SelectedItem.ToString() + " вече съществува.");
                        return;
                    }
                    else
                    {
                        LabelController.ChangeLabelVisibility(ref label30, true);
                        LabelController.ChangeLabelText(ref label30, "Въведеният разход за интернет" + 
                                                        " за периода " + 
                                                        year.Text + "/" + 
                                                        months.SelectedItem.ToString() + " е успешно добавен.");
                    }
                }

                LabelController.ChangeLabelVisibility(ref label30, true);
                LabelController.ChangeLabelText(ref label30, "Разходите за периода " + 
                                                year.Text + "/" + 
                                                months.SelectedItem.ToString() + " са успешно добавени.");
            }
        }

        private void seeExpenses_Click(object sender, EventArgs e)
        {
            TextBoxController.ChangeThreeTextBoxesText(ref electricity, ref water, ref internet, "", "", "");

            if (year.Text.Length != 4 || months.SelectedItem == null)
            {
                LabelController.ChangeLabelVisibility(ref label30, true);
                LabelController.ChangeLabelText(ref label30, "Моля въведете валидни данни за година/месец.");
            }
            else
            {
                string dateString = year.Text + months.SelectedItem.ToString() + "01T00:00:00Z";
                List<Expenses> expenses = FormToDBController.GetExpensesFromDataBase(ref controller, dateString);
                if (expenses.Count != 0)
                {
                    foreach(Expenses expense in expenses)
                    {
                        if(expense.Name == "Ток")
                        {
                            TextBoxController.ChangeTextBoxText(ref electricity, expense.Value.ToString());
                        }
                        else if (expense.Name == "Вода") 
                        {
                            TextBoxController.ChangeTextBoxText(ref water, expense.Value.ToString());
                        }
                        else if (expense.Name == "Интернет")
                        {
                            TextBoxController.ChangeTextBoxText(ref internet, expense.Value.ToString());
                        }
                    }
                }
                else
                {
                    LabelController.ChangeLabelVisibility(ref label30, true);
                    LabelController.ChangeLabelText(ref label30, "Няма добавени разходи за периода " + 
                                                    year.Text + "/" + 
                                                    months.SelectedItem.ToString());
                }
            }
        }

        private void editExpenses_Click(object sender, EventArgs e)
        {
            string validation = expensesValidation();
            double eValue = 0, wValue = 0, iValue = 0;
            if (validation != "f")
            {
                if (validation.Contains("e"))
                {
                    eValue = double.Parse(electricity.Text);
                }
                if (validation.Contains("w"))
                {
                    wValue = double.Parse(water.Text);
                }
                if (validation.Contains("i"))
                {
                    iValue = double.Parse(internet.Text);
                }
                string dateString = year.Text + months.SelectedItem.ToString() + "01T00:00:00Z";
                if (FormToDBController.EditExpensesInDataBase(ref controller, dateString, eValue, wValue, iValue) == false)
                {
                    LabelController.ChangeLabelVisibility(ref label30, true);
                    LabelController.ChangeLabelText(ref label30, "Някой от разходите, който се опитвате да редактирате за периода, не съществува.");
                }
                else
                {
                    LabelController.ChangeLabelVisibility(ref label30, true);
                    LabelController.ChangeLabelText(ref label30, "Разходите са успешно редактирани.");
                }
            }
        }

        private void addAccountingForDay_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            if(day.Length < 2)
            {
                day = "0" + day;
            }

            if(month.Length < 2)
            {
                month = "0" + month;
            }

            string dateString = year.ToString() + month.ToString() + day.ToString() + "T00:00:00Z";
            //MessageBox.Show(dateString);

            //double expenses = FormToDBController.GetDayReportExpensesFromDataBase(ref controller, dateString);
            //double incomes = FormToDBController.GetDayReportIncomesFromDataBase(ref controller, dateString);

            List<DayAccountings> dayAccountings = controller.GetDayAccountings(dateString);

            double expenses = 0, incomes = 0, profit = 0;

            foreach(DayAccountings accounting in dayAccountings)
            {
                expenses += accounting.DayExpense;
                incomes += accounting.DayIncome;
                profit += accounting.DayProfit;
            }

            TextBoxController.ChangeTextBoxText(ref dayExpenses, expenses.ToString());
            TextBoxController.ChangeTextBoxText(ref dayIncomes, incomes.ToString());
            TextBoxController.ChangeTextBoxText(ref dayProfit, profit.ToString());
        }

        private void addAccountingForMonth_Click(object sender, EventArgs e)
        {
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            if (month.Length < 2)
            {
                month = "0" + month;
            }

            string dateString = year.ToString() + month.ToString() + "01T00:00:00Z";

            List<Expenses> otherExpensesForMonth = FormToDBController.GetExpensesFromDataBase(ref controller, dateString);
            double expenses = 0;
            double incomes = 0;

            foreach(Expenses expense in otherExpensesForMonth)
            {
                expenses += expense.Value;
            }

            TextBoxController.ChangeTextBoxText(ref monthExpenses, expenses.ToString());
            TextBoxController.ChangeTextBoxText(ref monthIncomes, incomes.ToString());

            double profit = CalculateProfit(incomes, expenses);

            TextBoxController.ChangeTextBoxText(ref monthProfit, profit.ToString());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new ManagerHome(controller).Show();
            this.Hide();
        }

        private void AccountingForm_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
