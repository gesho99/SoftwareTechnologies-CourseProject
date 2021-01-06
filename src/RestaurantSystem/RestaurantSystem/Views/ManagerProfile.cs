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

namespace RestaurantSystem.Views
{
    public partial class ManagerProfile : Form
    {
        public ManagerProfile()
        {
            InitializeComponent();
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
    }
}
