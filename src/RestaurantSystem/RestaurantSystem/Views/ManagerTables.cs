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
    public partial class ManagerTables : Form
    {
        //DBController controller;

        public ManagerTables(DBController controller)
        {
            InitializeComponent();
            FillCategoryList();
            FillTablesList();
        }

        decimal bill = 0;
        
        private void back_Click(object sender, EventArgs e)
        {
            // add controller ManagerHome managerHome = new ManagerHome();
            //managerHome.Show();
            this.Hide();
        }

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

            string tableNumText = tableNum.Text.Substring(5, tableNum.Text.Length - 5);

            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            string sql = $"INSERT INTO dbo.MonthAccountings1 ( TableNum, TableName, Products, Quantity, Price, Date) VALUES ('{tableNumText}','{tableNum.Text}', '{itemsList.Text}', '{numericUpDown1.Value.ToString()}', '{String.Format("{0:0.00}", bill)}', '{dateTxt.Text}');";
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

            productsList.Text += productsString;
            priceTxt.Text = String.Empty;
            numericUpDown1.Text = "1";
            itemsList.Text = String.Empty;
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            //string tableName = tableNum.Text;
            //string billText = billTxt.Text;
            //string currentDate = dateTxt.Text;

            productsList.Text = String.Empty;
            billTxt.Text = "0 лв.";
            bill = 0;
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
                    string tableName = reader.GetString(2);
                    tablesCombo.Items.Add(tableName);
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
            string sql = $"INSERT INTO dbo.Tables (Id, Number, Name) VALUES ({tablesCount + 1},'{tablesCount + 1}','Маса {tablesCount + 1}');";
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
    }
}
