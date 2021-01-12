using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestaurantSystem.Controllers;
using RestaurantSystem.Data.Models;

namespace RestaurantSystem
{
    public partial class AddUser : Form
    {
        DBController controller;
        public AddUser(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadEmployees();
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
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
        }

        public void LoadEmployees()
        {
            List<Employee> employees = FormToDBController.SelectEmployees(ref controller);
            foreach (Employee emp in employees)
            {
                StaffcomboBox.Items.Add(emp.FirstName + " " + emp.LastName);
            }
        }

        private void StaffcomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadEmployeeProperties();
        }

        public void LoadEmployeeProperties()
        {
            string employeeName = StaffcomboBox.SelectedItem.ToString();
            string employeeFirstName = employeeName.Split(' ')[0];
            string employeeLastName = employeeName.Split(' ')[1];

            JobPosition.Text = FormToDBController.GetEmployerJobPosition(ref controller, employeeFirstName, employeeLastName);

            usernameTextbox.Text = FormToDBController.GetEmployerUserName(ref controller, employeeFirstName, employeeLastName);
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
                 
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            new ManagerHome(controller).Show();
            this.Hide();
        }

        private void AddUser_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
