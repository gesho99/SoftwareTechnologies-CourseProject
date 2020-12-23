using RestaurantSystem.Controllers;
using RestaurantSystem.Data;
using RestaurantSystem.Models;
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
    public partial class ProductsInStockForm : Form
    {
        Controller controller;
        public ProductsInStockForm(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadProducts();
        }

        public ProductsInStockForm()
        {
            InitializeComponent();
        }
        

        public void LoadProducts()
        {
            ClearProducts();
            ICollection<Product> products = LoadProductsFromDataBase();

            foreach (Product pr in products)
            {
                ItemsInStock.Items.Add(pr.Name);
                Parameters.Items.Add(pr.Quantity + " " + pr.Price + " " + pr.DeliveryPrice);
            }
        }

        public bool ChangeLabelVisibility(Label label, bool visibility)
        {
            label.Visible = visibility;
            return label.Visible;
        }

        public string ChangeLabelText(Label label, String text)
        {
            label.Text = text;
            return label.Text;
        }

        public void ClearProducts()
        {
            ItemsInStock.Items.Clear();
            Parameters.Items.Clear();
        }

        public ICollection<Product> LoadProductsFromDataBase()
        {
            return controller.LoadProducts();
        }

        public void AddProductInDataBase(string prName, int quantity, double prPrice, double dlPrice)
        {
            controller.AddProduct(prName, quantity, prPrice, dlPrice);
        }

        public void EditProductInDataBase(string prName, int quantity, double prPrice, double dlPrice)
        {
            controller.EditProduct(prName, quantity, prPrice, dlPrice);
        }

        public ListBox AddProductAsItem(string productName)
        {
            ItemsInStock.Items.Add(productName);
            return ItemsInStock;
        }

        public ListBox AddProductParameters(int quantity, double prPrice, double dlPrice)
        {
            Parameters.Items.Add(quantity + " " + prPrice + " " + dlPrice);
            return Parameters;
        }

        public bool ProductValidation(string productQuantity, string productPrice, string deliveryPrice, string productName)
        {
            try
            {
                ChangeLabelVisibility(label11, false);
                ChangeLabelText(label11, "");
                int quantity = int.Parse(productQuantity);
                double prPrice = double.Parse(productPrice);
                double dlPrice = double.Parse(deliveryPrice);
                string prName = productName;

                if (quantity <= 0)
                {
                    ChangeLabelVisibility(label11, true);
                    ChangeLabelText(label11, "Моля въведете количество по-голямо от нула.");
                    return false;
                }
                else if (prPrice <= 0)
                {
                    ChangeLabelVisibility(label11, true);
                    ChangeLabelText(label11, "Моля въведете цена на продукта по - голяма или равна на нула.");
                    return false;
                }
                else if (dlPrice <= 0)
                {
                    ChangeLabelVisibility(label11, true);
                    ChangeLabelText(label11, "Моля въведете доставна цена по - голяма или равна на нула.");
                    return false;
                }
                else if (prName.Length <= 2)
                {
                    ChangeLabelVisibility(label11, true);
                    ChangeLabelText(label11, "Моля въведете валидно име на продукта.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                ChangeLabelVisibility(label11, true);
                ChangeLabelText(label11, "Моля въведете валидни данни.");
                return false;
            }
            catch (OverflowException)
            {
                ChangeLabelVisibility(label11, true);
                ChangeLabelText(label11, "Моля въведете валидни данни.");
                return false;
            }
        }

        //Добавяне на продукт
        public void button1_Click(object sender, EventArgs e)
        {
            if (ProductValidation(productQuantity.Text, productPrice.Text, deliveryPrice.Text, productName.Text) == true)
            {
                int quantity = int.Parse(productQuantity.Text);
                double prPrice = double.Parse(productPrice.Text);
                double dlPrice = double.Parse(deliveryPrice.Text);
                string prName = productName.Text;

                if (ItemsInStock.Items.Contains(prName))
                {
                    ChangeLabelVisibility(label11, true);
                    ChangeLabelText(label11, "Този продукт вече е добавен. Ако искате да го редактирате моля натиснете бутона редактирай.");
                }
                else
                {
                    AddProductInDataBase(prName, quantity, prPrice, dlPrice);
                    AddProductAsItem(prName);
                    AddProductParameters(quantity, prPrice, dlPrice);
                }
            }
        }

        //Редактиране на продукт
        public void button2_Click(object sender, EventArgs e)
        {
            if (ProductValidation(productQuantity.Text, productPrice.Text, deliveryPrice.Text, productName.Text) == true)
            {
                int quantity = int.Parse(productQuantity.Text);
                double prPrice = double.Parse(productPrice.Text);
                double dlPrice = double.Parse(deliveryPrice.Text);
                string prName = productName.Text;

                if (!ItemsInStock.Items.Contains(prName))
                {
                    ChangeLabelVisibility(label11, true);
                    ChangeLabelText(label11, "Продуктът, който се опитвате да редактирате, не съществува.");
                }
                else
                { 
                    EditProductInDataBase(prName, quantity, prPrice, dlPrice);
                    LoadProducts();
                }
            }
        }

        private void ProductsInStockForm_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            new HomeAdmin(controller).Show();
            this.Hide();
        }
    }
}