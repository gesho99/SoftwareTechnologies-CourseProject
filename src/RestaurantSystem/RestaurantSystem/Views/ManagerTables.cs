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
using RestaurantSystem.Data.Models;

namespace RestaurantSystem.Views
{
    public partial class ManagerTables : Form
    {
        public ManagerTables(DBController controller)
        {
            InitializeComponent();
            InsertFirstTableIntoDB();
            FillCategoryList();
            FillTablesList();
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            dateTxt.Text = date;
        }
        private void LoadTheme()
        {
            foreach (Control btns in groupBox1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control btns in groupBox3.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control btns in groupBox4.Controls)
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

        decimal bill = 0;

        private void ManagerTables_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            dateTxt.Text = date;
        }

        public void FillCategoryList()
        {
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            string sql = "select * from Dishes";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();               
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string category = reader.GetString(1);
                    itemsList.Items.Add(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productName = itemsList.Text;
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            string sql = $"SELECT dbo.Dishes.DishPrice FROM dbo.Dishes WHERE dbo.Dishes.DishName = '{productName}'";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string price = reader.GetString(0);
                    priceTxt.Text = price.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (itemsList.Text != "" && numericUpDown1.Value != 0 && priceTxt.Text != "" && tablesCombo.Text != "")
            {
                string product = itemsList.Text;
                decimal quantity = numericUpDown1.Value;
                string price = priceTxt.Text;
                decimal priceVal = Convert.ToDecimal(price);
                decimal itemsPrice = quantity * priceVal;
                string priceFormat = String.Format("{0:0.00}", itemsPrice);
                string productsString = $"{product}, к-во: {quantity}, цена: {priceFormat} лв. {Environment.NewLine}";

                bill += itemsPrice;
                string billFormat = String.Format("{0:0.00} лв.", bill);
                billTxt.Text = billFormat;
               
                SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
                SqlDataReader reader;

                string sqlSelectSellingPrice = $"SELECT DishSellingPrice FROM dbo.Dishes WHERE DishName='Снежанка'";
                SqlCommand commandSelectSellingPrice = new SqlCommand(sqlSelectSellingPrice, con);
                object sellingPrice = 0;
                try
                {
                    con.Open();
                    reader = commandSelectSellingPrice.ExecuteReader();
                    while (reader.Read())
                    {
                        sellingPrice = reader.GetValue(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                string sqlSelectMakingPrice = $"SELECT DishMakingPrice FROM dbo.Dishes WHERE DishName='Снежанка'";
                SqlCommand commandSelectMakingPrice = new SqlCommand(sqlSelectMakingPrice, con);
                object makingPrice = 0;
                try
                {
                    con.Open();
                    reader = commandSelectMakingPrice.ExecuteReader();
                    while (reader.Read())
                    {
                        makingPrice = reader.GetValue(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                /*date
                string day = DateTime.Now.Day.ToString();
                string month = DateTime.Now.Month.ToString();
                string year = DateTime.Now.Year.ToString();

                if (month.Length < 2)
                {
                    month = "0" + month;
                }

                if (day.Length < 2)
                {
                    day = "0" + day;
                }

                string dateString = year.ToString() + month.ToString() + day.ToString() + "T00:00:00Z";
                DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
                //end of date

                string sqlInsert = $"INSERT INTO dbo.DayAccountings ( MonthAccountingId, DayExpense, DayIncome, DayProfit, Date) VALUES (1, {makingPrice}, {sellingPrice}, 0, {today});";
                SqlCommand commandInsert = new SqlCommand(sqlInsert, con);
                con.Open();
                reader = commandInsert.ExecuteReader();
                /*
                try
                {        
                    con.Open();
                    reader = commandInsert.ExecuteReader();
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message);
                }
                */
                con.Close();

                productsList.Text += productsString;
                priceTxt.Text = String.Empty;
                numericUpDown1.Text = "1";
                itemsList.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Моля, изберете ястие, количество и съответната маса!");
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // Създаване на pdf със сметката и ДАТА?

            productsList.Text = String.Empty;
            billTxt.Text = "0 лв.";
            bill = 0;
        }
        public void InsertFirstTableIntoDB()
        {
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");

            string sqlInsert = $"INSERT INTO dbo.Tables (Number) VALUES ({1});";
            SqlCommand commandInsert = new SqlCommand(sqlInsert, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = commandInsert.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void FillTablesList()
        {
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            string sql = "select * from Tables";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tableName = reader.GetString(1);
                    tablesCombo.Items.Add($"Маса {tableName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tablesAddBtn_Click(object sender, EventArgs e)
        {
            int tablesCount = tablesCombo.Items.Count;
            if (tablesCount == 0)
            {
                tablesCombo.Items.Add("Маса 1");
            }
            else
            {
                tablesCombo.Items.Add($"Маса {tablesCount + 1}");
            }
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            string sql = $"INSERT INTO dbo.Tables (Number) VALUES ('{tablesCount + 1}');";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tablesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTableNum = tablesCombo.Text;
            tableNum.Text = selectedTableNum;
        }

        private void ManagerTables_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productName = itemsList.Text;
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            string sql = $"SELECT dbo.Dishes.DishSellingPrice FROM dbo.Dishes WHERE dbo.Dishes.DishName = '{productName}'";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object price = reader.GetValue(0);
                    priceTxt.Text = $"{String.Format("{0:0.00}", price)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
