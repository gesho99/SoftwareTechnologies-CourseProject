using RestaurantSystem.Controllers;
using RestaurantSystem.Data;
using RestaurantSystem.Data.Models;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantSystem.Views
{
    public partial class ManagerTables : Form
    {
        RestaurantDbContext db = new RestaurantDbContext();

        public void CreateDB()
        {
            db = new RestaurantDbContext();
            db.Database.CreateIfNotExists();
        }

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

        private int SelectDishId()
        {
            string product = itemsList.Text;
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            SqlDataReader reader;

            string sqlSelectId = $"SELECT Id FROM dbo.Dishes WHERE DishName='{product}'";
            SqlCommand commandSelectId = new SqlCommand(sqlSelectId, con);

            object id = 0;

            try
            {
                con.Open();
                reader = commandSelectId.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetValue(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            int idValue = Convert.ToInt32(id);
            
            return idValue;
        }

        private int[] SelectproductsQuantities()
        {
            string product = itemsList.Text;
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            SqlDataReader reader;

            string sqlSelectProducts = $"SELECT ProductsQuantity FROM dbo.Dishes WHERE DishName='{product}'";
            SqlCommand commandSelectProducts = new SqlCommand(sqlSelectProducts, con);

            object quantity = 0;
            try
            {
                con.Open();
                reader = commandSelectProducts.ExecuteReader();
                while (reader.Read())
                {
                    quantity = reader.GetValue(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            string quantitiStr = quantity.ToString();
            string[] quantityVals = quantitiStr.Split(' ');
            int[] quantityArr = new int[quantityVals.Length];

            for (int i = 0; i < quantityVals.Length; i++)
            {
                int currentVal = Int32.Parse(quantityVals[i]);
                quantityArr[i] = currentVal;
            }

            return quantityArr;
        }

        private string SelectDishProducts(int dishId)
        {
            int id = dishId;
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            SqlDataReader reader;

            string sqlProductId = $"SELECT ProductId FROM dbo.DishProducts WHERE DishId='{id}'";
            SqlCommand commandSelectSellingPrice = new SqlCommand(sqlProductId, con);
            object currentId = 0;
            string idString = "";
            try
            {
                con.Open();
                reader = commandSelectSellingPrice.ExecuteReader();
                while (reader.Read())
                {
                    currentId = reader.GetValue(0);
                    string idValue = currentId.ToString();
                    idString += idValue + ",";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return idString;
        }

        private void DecreaseQuantity(int[] idList, int[] quantitiesList)
        {
            int[] ids = idList;
            int[] qList = quantitiesList;
            decimal q = numericUpDown1.Value;
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            SqlDataReader reader;
            for (int i = 0; i < idList.Length - 1; i++)
            {
                string sqlProductId = $"SELECT Quantity FROM dbo.Products WHERE Id='{idList[i]}'";
                SqlCommand commandSelectId = new SqlCommand(sqlProductId, con);
                object quantity = 0;
                int quantityValue = 0;
                try
                {
                    con.Open();
                    reader = commandSelectId.ExecuteReader();
                    while (reader.Read())
                    {
                        quantity = reader.GetValue(0);
                        quantityValue = Convert.ToInt32(quantity);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

                decimal quantityToDecrease = qList[i] * q;
                if (quantityValue - quantityToDecrease >= qList[i]) {
                    string sqlUpdate = $"UPDATE dbo.Products SET Quantity={quantityValue - quantityToDecrease} WHERE Id='{idList[i]}'";
                    SqlCommand commandUpdate = new SqlCommand(sqlUpdate, con);
                    try
                    {
                        con.Open();
                        reader = commandUpdate.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Недостатъчно количество!");
                }
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

                string sqlSelectSellingPrice = $"SELECT DishSellingPrice FROM dbo.Dishes WHERE DishName='{product}'";
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

                string sqlSelectMakingPrice = $"SELECT DishMakingPrice FROM dbo.Dishes WHERE DishName='{product}'";
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

                CreateDB();
                string dateString = year.ToString() + month.ToString() + day.ToString() + "T00:00:00Z";
                DateTime today = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

                double makingPriceValue = Convert.ToDouble(makingPrice);
                double sellingPriceValue = Convert.ToDouble(sellingPrice);
                double qunatityValue = Convert.ToDouble(quantity);

                DayAccountings acc = new DayAccountings();
                db.DayAccountings.Add(new DayAccountings
                {
                    DayExpense = makingPriceValue * qunatityValue,
                    DayIncome = sellingPriceValue * qunatityValue,
                    DayProfit = (sellingPriceValue * qunatityValue) - (makingPriceValue * qunatityValue),
                    Date = today,
                    MonthAccountingId = 1
                });
                db.SaveChanges();

                int dishId = SelectDishId();
                int[] prodQuantities = SelectproductsQuantities(); 
                string productsInDish = SelectDishProducts(dishId);
                string[] idsList = productsInDish.Split(',');
                int[] idsValuesList = new int[idsList.Length];
                
                for (int i = 0; i < idsList.Length - 1; i++)
                {
                    string id = idsList[i];
                    int idValue = Int32.Parse(id);
                    idsValuesList[i] = idValue;
                }
                DecreaseQuantity(idsValuesList, prodQuantities);

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
            productsList.Text = String.Empty;
            tableNum.Text = String.Empty;
            billTxt.Text = "0 лв.";
            bill = 0;
        }

        public void InsertFirstTableIntoDB()
        {
            SqlConnection con = new SqlConnection("data source=localhost; initial catalog=RestaurantDataBase; integrated security=true");
            SqlDataReader reader;

            string sqlSelect = $"SELECT * FROM dbo.Tables WHERE dbo.Tables.Number = '1'";
            SqlCommand commandSelect = new SqlCommand(sqlSelect, con);
            object obj = null;
            try
            {
                con.Open();
                reader = commandSelect.ExecuteReader();
                while (reader.Read())
                {
                    obj = reader.GetValue(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            if (obj == null)
            {
                string sqlInsert = $"INSERT INTO dbo.Tables (Number) VALUES ({1});";
                SqlCommand commandInsert = new SqlCommand(sqlInsert, con);
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
