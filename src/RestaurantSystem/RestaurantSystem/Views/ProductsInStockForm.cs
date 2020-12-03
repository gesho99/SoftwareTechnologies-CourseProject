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
            ICollection<Product> products = controller.LoadProducts();
            foreach(Product pr in products){
                ItemsInStock.Items.Add(pr.Name);
                Parameters.Items.Add(pr.Quantity + " " + pr.Price + " " + pr.DeliveryPrice);
            }
        }

        private bool productValidation()
        {
            try
            {
                label11.Visible = false;
                label11.Text = "";
                int quantity = int.Parse(productQuantity.Text);
                double prPrice = double.Parse(productPrice.Text);
                double dlPrice = double.Parse(deliveryPrice.Text);
                string prName = productName.Text;

                if (quantity <= 0)
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете количество по-голямо от нула.";
                    return false;
                }
                else if (prPrice < 0)
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете цена на продукта по - голяма или равна на нула.";
                    return false;
                }
                else if (dlPrice < 0)
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете доставна цена по - голяма или равна на нула.";
                    return false;
                }
                else if (prName == "")
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете името на продукта.";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                label11.Visible = true;
                label11.Text = "Моля въведете валидни данни.";
                return false;
            }
            catch (OverflowException)
            {
                label11.Visible = true;
                label11.Text = "Моля въведете валидни данни.";
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productValidation() == true)
            {
                int quantity = int.Parse(productQuantity.Text);
                double prPrice = double.Parse(productPrice.Text);
                double dlPrice = double.Parse(deliveryPrice.Text);
                string prName = productName.Text;

                if (ItemsInStock.Items.Contains(prName))
                {
                    label11.Visible = true;
                    label11.Text = "Този продукт вече е добавен. Ако искате да го редактирате моля натиснете бутона редактирай.";
                }
                else
                {
                    controller.AddProduct(prName, quantity, prPrice, dlPrice);
                    ItemsInStock.Items.Add(productName.Text);
                    Parameters.Items.Add(quantity + " " + prPrice + " " + dlPrice );
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (productValidation() == true)
            {
                int quantity = int.Parse(productQuantity.Text);
                double prPrice = double.Parse(productPrice.Text);
                double dlPrice = double.Parse(deliveryPrice.Text);
                string prName = productName.Text;

                if (!ItemsInStock.Items.Contains(prName))
                {
                    label11.Visible = true;
                    label11.Text = "Продуктът, който се опитвате да редактирате, не съществува.";
                }
                else
                {
                    String parameters = Parameters.Items[ItemsInStock.Items.IndexOf(prName)].ToString();
                    String[] splittedParameters = parameters.Split(' ');
                    splittedParameters[0] = quantity.ToString();
                    splittedParameters[1] = prPrice.ToString();
                    splittedParameters[2] = dlPrice.ToString();
                    Parameters.Items[ItemsInStock.Items.IndexOf(prName)] = splittedParameters[0] + " " + splittedParameters[1] + " " + splittedParameters[2];
                }
            }

        }

        private void ProductsInStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}

