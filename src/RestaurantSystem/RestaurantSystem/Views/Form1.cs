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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Username.Select(0, 0);
            Password.UseSystemPasswordChar = false;
        }
        

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if(Username.Text=="  Enter Username:")
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
            if(Username.Text=="  Enter Username:")
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
            if(Password.Text=="  Enter Password:")
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

        private void Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (Admin.Checked)
            {
                Username.Text = "admin";
                Username.ReadOnly = true;
                Password.Text = "admin";
            }
            else
            {
                Username.ForeColor = Color.DarkGray;
                Username.Text = "  Enter Username:";
                Username.ReadOnly = false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
