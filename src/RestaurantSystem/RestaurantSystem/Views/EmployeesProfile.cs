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
    public partial class Employees : Form
    {
        DBController controller;
        string username;
        public Employees(DBController controller, string username)
        {
            this.controller = controller;
            this.username = username;
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
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            LoadTheme();
            Employee employer = FormToDBController.GetEmployerByUserName(ref controller, username);
            textBox1.Text = employer.FirstName;
            textBox2.Text = employer.LastName;
            textBox3.Text = employer.Email;
            textBox4.Text = employer.JobPosition;
            textBox5.Text = employer.Salary.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
