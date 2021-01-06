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

        DBController controller;

        public Menu(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadDishes();
        }
        

        public void LoadDishes()
        {
            ListBoxController.ClearItems(ref menuItems);
            ListBoxController.ClearItems(ref menuItemsParameters);

            ICollection<Dish> Dishes = FormToDBController.LoadDishesFromDataBase(ref controller);

            foreach(Dish dish in Dishes)
            {
                ListBoxController.AddListBoxItems(ref menuItems, dish.DishName);
                ListBoxController.AddListBoxParameters(ref menuItemsParameters, dish.DishPrice, dish.Products.ToString(), dish.DishWeight);
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
                    LabelController.ChangeLabelText(ref label6, "Моля въведете тегло по - голямо от нула");
                    return false;
                }
                else if (dPrice <= 0)
                {
                    LabelController.ChangeLabelText(ref label6, "Моля въведете цена на ястие по - голяма от нула");
                    return false;
                }
                else if (dName.Length < 3 || productNamesInDish.Length < 3)
                {
                    LabelController.ChangeLabelText(ref label6, "Моля въведете валидно име на ястие / продукти в ястието");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                LabelController.ChangeLabelText(ref label6, "Моля въведете валидни данни.");
                return false;
            }
            catch (OverflowException)
            {
                LabelController.ChangeLabelText(ref label6, "Моля въведете валидни данни.");
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
                    Product product = FormToDBController.SelectProductByNameFromDataBase(ref controller, productName);
                    if (product != null)
                    {
                        productsInDish.Add(product);
                    }
                    else
                    {
                        LabelController.ChangeLabelText(ref label6, "Въведеният продукт " + productName + " не е наличен.");
                        return;
                    }
                }

                FormToDBController.AddDishesToDataBase(ref controller, dName, dPrice, dWeight, productsInDish);
                LoadDishes();
            }
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {

            if (productValidation() == true)
            {

                ICollection<Product> productsInDish = new HashSet<Product>();
                String[] productNamesInDish = products.Text.Split(' ');
                double dPrice = double.Parse(itemPrice.Text);
                double dWeight = double.Parse(itemWeight.Text);
                string dName = itemName.Text;       

                if (!menuItems.Items.Contains(dName))
                {
                    LabelController.ChangeLabelText(ref label6, "Ястието, което се опитвате да редактирате, не съществува.");
                }
                else
                {
                    foreach (String productName in productNamesInDish)
                    {
                        Product product = FormToDBController.SelectProductByNameFromDataBase(ref controller, productName);
                        if (product != null)
                        {
                            productsInDish.Add(product);
                        }
                        else
                        {
                            LabelController.ChangeLabelText(ref label6, "Въведеният продукт " + productName + " не е наличен.");
                            return;
                        }
                    }

                    FormToDBController.EditDishInDataBase(ref controller, dName, dPrice, dWeight, productsInDish);
                    LoadDishes();
                }

            }

        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            string dName = itemName.Text;

            if (dName.Length < 3)
            {
                LabelController.ChangeLabelText(ref label6, "Моля въведете валидно име на ястие");
            }
            else
            {
                if (!controller.RemoveDish(dName))
                {
                    LabelController.ChangeLabelText(ref label6, "Въведеното ястие " + dName + " не съществува.");
                }
                else
                {
                    LoadDishes();
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new HomeAdmin(controller).Show();
            this.Hide();
        }
    }
}
