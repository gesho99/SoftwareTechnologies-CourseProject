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


namespace LoginForm
{
    public partial class AddUser : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public AddUser()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-MJGIC87;Initial Catalog=RestaurantDataBase;Integrated Security=True";
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * From Employers";
            com.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["FirstName"].ToString());
                    
            }
            con.Close();


            comboBox2.Items.Clear();
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * From Roles";
            com.ExecuteNonQuery();

            DataTable datatable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            dataAdapter.Fill(datatable);

            foreach (DataRow datarow in datatable.Rows)
            {
                comboBox2.Items.Add(datarow["Name"].ToString());

            }
            con.Close();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Insert into Users (EmployerId, RoleId,Username,Password)";
            com.Parameters.AddWithValue("@EmployerId", comboBox1.SelectedValue);
            com.Parameters.AddWithValue("@RoleId", comboBox2.SelectedValue);
            com.Parameters.AddWithValue("@Username", usernameTextbox.Text);
            com.Parameters.AddWithValue("@Password", passwordTextbox);


            com.ExecuteNonQuery();
            con.Close();

        }
    }
}
