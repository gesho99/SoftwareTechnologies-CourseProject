using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantSystem.Data.Models;
using RestaurantSystem.Data;
using System.Data.Entity;
using RestaurantSystem.Views;
using RestaurantSystem.Controllers;
using System.Text.RegularExpressions;


namespace RestaurantSystem.Views
{
    public partial class ManagerProfile : Form
    {
        DBController controller;

        public ManagerProfile()
        {
            InitializeComponent();
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
            label5.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;

        }
        private void back_Click(object sender, EventArgs e)
        {
            new ManagerHome(controller).Show();
            this.Hide();
        }
        /*
        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Employee emp = employeeBindingSource.Current as Employee;
                }
            }
        }
        */
        private void ManagerProfile_Load(object sender, EventArgs e)
        {
            LoadTheme();
            using (RestaurantDbContext db = new RestaurantDbContext())
            {
                employeeBindingSource.DataSource = db.Employees.ToList();
            }
            panel1.Enabled = false;
            Employee emp = employeeBindingSource.Current as Employee;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            employeeBindingSource.Add(new Employee());
            employeeBindingSource.MoveLast();
            firstName.Focus();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            firstName.Focus();
            Employee emp = employeeBindingSource.Current as Employee;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            employeeBindingSource.ResetBindings(false);
            ManagerProfile_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee emp = employeeBindingSource.Current as Employee;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (RestaurantDbContext db = new RestaurantDbContext())
                {
                    Employee emp = employeeBindingSource.Current as Employee;
                    if (emp != null)
                    {
                        if (db.Entry<Employee>(emp).State == EntityState.Detached)
                        {
                            db.Set<Employee>().Attach(emp);
                        }
                        db.Entry<Employee>(emp).State = EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show(this, "Deleted successfully.");
                        employeeBindingSource.RemoveCurrent();
                        panel1.Enabled = false;
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (RestaurantDbContext db = new RestaurantDbContext())
            {
                if (firstName.Text != "" && lastName.Text != "" && emailBox.Text != "" && jobPosition.Text != "" && salaryBox.Text != "")
                {
                    string firstNameRegex = @"^([А-Я]{1})([а-я]+)(([-]{1}[А-Я]{1}[а-я]+)?)$";
                    Match firstNameMatch = Regex.Match(firstName.Text, firstNameRegex);

                    string lastNameRegex = @"^([А-Я]{1})([а-я]+)$";
                    Match lastNameMatch = Regex.Match(lastName.Text, lastNameRegex);

                    string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
                    Match emailMatch = Regex.Match(emailBox.Text, emailRegex);

                    string jobRegex = @"^([А-Я]{1})([а-я]+)(\/{0,1})([а-я]+)$";
                    Match jobMatch = Regex.Match(jobPosition.Text, jobRegex);

                    if (firstNameMatch.Success && lastNameMatch.Success && emailMatch.Success && jobMatch.Success) {
                        Employee emp = employeeBindingSource.Current as Employee;
                        if (emp != null)
                        {
                            if (db.Entry<Employee>(emp).State == EntityState.Detached)
                            {
                                db.Set<Employee>().Attach(emp);
                            }
                            if (emp.EmpId == 0)
                            {
                                db.Entry<Employee>(emp).State = EntityState.Added;
                            }
                            else
                            {
                                db.Entry<Employee>(emp).State = EntityState.Modified;
                            }
                            db.SaveChanges();
                            MessageBox.Show(this, "Saved successfully!");
                            dataGridView1.Refresh();
                            panel1.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Моля, попълнете правилно нужните данни.");
                    }
                }
                else
                {
                    MessageBox.Show("Попълнете полетата с нужните данни.");
                }
            }           
        }
    }
}
