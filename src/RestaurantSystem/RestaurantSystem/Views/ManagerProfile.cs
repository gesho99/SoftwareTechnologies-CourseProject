﻿using System;
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



namespace RestaurantSystem.Views
{
    public partial class ManagerProfile : Form
    {
        DBController controller;

        public ManagerProfile()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new ManagerHome(controller).Show();
            this.Hide();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Employee emp = employeeBindingSource.Current as Employee;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    
                    if (emp != null)
                    {
                        emp.ImageUrl = ofd.FileName;
                    }
                }
            }
        }

        private void ManagerProfile_Load(object sender, EventArgs e)
        {
            using (RestaurantDbContext db = new RestaurantDbContext())
            {
                employeeBindingSource.DataSource = db.EmployeesList.ToList();
            }
            panel1.Enabled = false;
            Employee emp = employeeBindingSource.Current as Employee;
            if (emp != null)
            {
                pictureBox1.Image = Image.FromFile(emp.ImageUrl);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
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
            if (emp != null)
            {
                pictureBox1.Image = Image.FromFile(emp.ImageUrl);
            }
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
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
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
        }
    }
}