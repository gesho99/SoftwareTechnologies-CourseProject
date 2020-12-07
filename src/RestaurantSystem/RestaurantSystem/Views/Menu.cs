using RestaurantSystem.Controllers;
using RestaurantSystem.Data.Models;
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
    public partial class Menu : Form
    {

        Controller controller;

        public Menu(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadDishes();
        }

        public void LoadDishes()
        {
            menuItems.Items.Clear();
            menuItemsParameters.Items.Clear();
            ICollection<Dish> Dishes = controller.LoadDishes();

            foreach(Dish dish in Dishes)
            {
                menuItems.Items.Add(dish.DishName);
                menuItemsParameters.Items.Add(dish.DishPrice + " " + dish.Products.ToString() + " " + dish.DishWeight);
            }
        }

            private bool productValidation()
        {
            try
            {
                String productNamesInDish = products.Text;
                double dPrice = double.Parse(itemPrice.Text);
                double dWeight = double.Parse(itemWeight.Text);
                string dName = itemName.Text;

                if (dWeight <= 0)
                {
                    label6.Text = "Моля въведете тегло по - голямо от нула";
                    return false;
                }
                else if (dPrice <= 0)
                {
                    label6.Text = "Моля въведете цена на ястие по - голяма от нула";
                    return false;
                }
                else if (dName.Length < 3 || productNamesInDish.Length < 3)
                {
                    label6.Text = "Моля въведете валидно име на ястие / продукти в ястието";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                label6.Text = "Моля въведете валидни данни.";
                return false;
            }
            catch (OverflowException)
            {
                label6.Text = "Моля въведете валидни данни.";
                return false;
            }
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            if (productValidation() == true)
            {

                ICollection<Product> productsInDish = new HashSet<Product>();
                String[] productNamesInDish = products.Text.Split(' ');
                double dPrice = double.Parse(itemPrice.Text);
                double dWeight = double.Parse(itemWeight.Text);
                string dName = itemName.Text;

                foreach (String productName in productNamesInDish)
                {
                    Product product = controller.SelectProductByName(productName);
                    if (product != null)
                    {
                        productsInDish.Add(product);
                    }
                    else
                    {
                        label6.Text = "Въведеният продукт " + productName + " не е наличен.";
                        return;
                    }
                }

                controller.AddDish(dName, dPrice, dWeight, productsInDish);
                menuItems.Items.Add(dName);
                menuItemsParameters.Items.Add(dPrice + " " + productNamesInDish.ToString() + " " + dWeight);

                foreach (String productName in productNamesInDish)
                {
                    Product product = controller.SelectProductByName(productName);
                    product.Dishes.Add(controller.SelectDishByName(dName));
                }
            }
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {

            if (productValidation() == true)
            {

                ICollection<Product> productsInDish = new HashSet<Product>();
                ICollection<Dish> dishesInproducts = new HashSet<Dish>();
                String[] productNamesInDish = products.Text.Split(' ');
                double dPrice = double.Parse(itemPrice.Text);
                double dWeight = double.Parse(itemWeight.Text);
                string dName = itemName.Text;       

                if (!menuItems.Items.Contains(dName))
                {
                    label6.Text = "Ястието, което се опитвате да редактирате, не съществува.";
                }
                else
                {
                    foreach (String productName in productNamesInDish)
                    {
                        Product product = controller.SelectProductByName(productName);
                        if (product != null)
                        {
                            Dish dish = controller.SelectDishByName(dName);
                            if (!dish.Products.Contains(product))
                            {
                                productsInDish.Add(product);
                                dishesInproducts.Add(dish);
                            }
                        }
                        else
                        {
                            label6.Text = "Въведеният продукт " + productName + " не е наличен.";
                            return;
                        }
                    }
                    controller.EditDish(dName, dPrice, dWeight, productsInDish);
                }

            }

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
