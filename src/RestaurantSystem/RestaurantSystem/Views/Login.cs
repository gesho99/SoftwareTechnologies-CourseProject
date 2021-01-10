using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestaurantSystem.Controllers;

namespace RestaurantSystem.Views
{
    public partial class Login : Form
    {
        DBController controller;
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private Random random;
        private int tempIndex;


        public Login(DBController controller)
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-MJGIC87;Initial Catalog=RestaurantDataBase;Integrated Security=True";
            Username.Select(0, 0);
            Password.UseSystemPasswordChar = false;
            this.controller = controller;
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (Username.Text == "  Enter Username:")
            {
                Username.Clear();
                Username.ForeColor = Color.Black;
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (Password.Text == "  Enter Password:")
            {
                Password.Clear();
                Password.ForeColor = Color.Black;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {
            if (Username.Text == "  Enter Username:")
            {
                Username.Clear();
                Username.ForeColor = Color.Black;
            }
            if (Password.Text.Length < 1)
            {
                Password.ForeColor = Color.DarkGray;
                Password.UseSystemPasswordChar = false;
                Password.Text = "  Enter Password:";
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {
            if (Password.Text == "  Enter Password:")
            {
                Password.Clear();
                Password.UseSystemPasswordChar = true;
                Password.ForeColor = Color.Black;
            }
            if (Username.Text.Length < 1)
            {
                Username.ForeColor = Color.DarkGray;
                Username.Text = "  Enter Username:";
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Password.Text.Length < 1)
            {
                Password.ForeColor = Color.DarkGray;
                Password.UseSystemPasswordChar = false;
                Password.Text = "  Enter Password";
            }
            if (Username.Text.Length < 1)
            {
                Username.ForeColor = Color.DarkGray;
            }
        }

        private void Show_MouseDown(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = false;
        }

        private void Show_MouseUp(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

            //new ManagerHome(controller).Show();
            //this.Hide();
           // new EmployeesHome(controller).Show();
            //this.Hide();


              con.Open();
              com.Connection = con;
              //com.CommandText = "select * from Users";
            com.CommandText = "select * from Users Where Username='"+Username.Text+"' AND Password='"+Password.Text+"' ";
            SqlDataReader dr = com.ExecuteReader();
              if (dr.Read())
              {
                  if ( dr["RoleId"].Equals(1))
                  {
                      new ManagerHome(controller).Show();
                     this.Hide();
                  }

                else 

                {

                    new EmployeesHome(controller).Show();
                    this.Hide();
                }
         
            }
            else
            {
                MessageBox.Show("Грешна парола или потребителско име");
            }
    

            con.Close();
          
        }
    }
}
