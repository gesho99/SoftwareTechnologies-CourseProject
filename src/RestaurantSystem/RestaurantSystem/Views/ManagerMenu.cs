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

            ICollection<Dish> dishes = FormToDBController.LoadDishesFromDataBase(ref controller);
            string products = string.Empty;
            string productsQuantities = string.Empty;

            foreach(Dish dish in dishes)
            {
                ListBoxController.AddListBoxItems(ref menuItems, dish.DishName);
                List<DishProducts> dishProducts = FormToDBController.SelectAllDishProducts(ref controller, dish.Id);

                int counter = 1;
                foreach(DishProducts dp in dishProducts)
                {
                    if(counter < dishProducts.Count) {
                        products += FormToDBController.SelectProductById(ref controller, dp.ProductId).Name + ",";
                    }
                    else
                    {
                        products += FormToDBController.SelectProductById(ref controller, dp.ProductId).Name + " ";
                    }

                    counter++;
                }

                string[] productsQuantitiesSplitted = dish.ProductsQuantity.Split(' ');

                int counter2 = 1;
                foreach(string quantity in productsQuantitiesSplitted)
                {
                    if (counter2 < productsQuantitiesSplitted.Length)
                    {
                        productsQuantities += quantity + ",";
                    }
                    else
                    {
                        productsQuantities += quantity + " ";
                    }
                    counter2++;
                }

                ListBoxController.AddListBoxParameters(ref menuItemsParameters, dish.DishSellingPrice, products, productsQuantities, dish.DishWeight);

                products = string.Empty;
                productsQuantities = string.Empty;
            }
        }

        private bool productValidation()
        {
            try
            {
                string productNamesInDish = products.Text;
                double dPrice = double.Parse(itemPrice.Text);
                double dWeight = double.Parse(itemWeight.Text);
                string dName = itemName.Text;
                string[] productsQuantities = productQuantities.Text.Split(' ');
                string[] productNamesInDishSplitted = products.Text.Split(' ');
                List<double> productsQuantitiesAsDouble = new List<double>();

                foreach(string quantity in productsQuantities)
                {
                    productsQuantitiesAsDouble.Add(double.Parse(quantity));
                }

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
                else if(productsQuantities.Length != productNamesInDishSplitted.Length)
                {
                    LabelController.ChangeLabelText(ref label6, "Моля въведете съответните количества за всяко едно ястие");
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
        private void LoadTheme()
        {
            foreach (Control btns in groupBox2.Controls)
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
            label14.ForeColor = ThemeColor.SecondaryColor;
            label12.ForeColor = ThemeColor.PrimaryColor;

        }
        private void addMenuItem_Click(object sender, EventArgs e)
        {
            if (productValidation() == true)
            {

                ICollection<int> productsIds = new HashSet<int>();
                String[] productNamesInDish = products.Text.Split(' ');
                double dPrice = double.Parse(itemPrice.Text);
                double dWeight = double.Parse(itemWeight.Text);
                string dName = itemName.Text;
                String[] productsQuantity = productQuantities.Text.Split(' ');
                int counter = 0;

                foreach (String productName in productNamesInDish)
                {
                    Product product = FormToDBController.SelectProductByNameFromDataBase(ref controller, productName);
                    if (product != null)
                    {
                        productsIds.Add(product.Id);
                        if(product.Quantity < int.Parse(productsQuantity[counter]))
                        {
                            LabelController.ChangeLabelText(ref label6, "Количеството на продукта " + product.Name + " не достига.");
                            return;
                        }
                    }
                    else
                    {
                        LabelController.ChangeLabelText(ref label6, "Въведеният продукт " + productName + " не е наличен.");
                        return;
                    }
                    counter++;
                }

                FormToDBController.AddDishesToDataBase(ref controller, dName, dPrice, dWeight, productsIds, productQuantities.Text);
                LoadDishes();
            }
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {

            if (productValidation() == true)
            {

                ICollection<Product> productsInDish = new HashSet<Product>();
                string[] productNamesInDish = products.Text.Split(' ');
                double dPrice = double.Parse(itemPrice.Text);
                double dWeight = double.Parse(itemWeight.Text);
                string dName = itemName.Text;
                string productsQuantities = productQuantities.Text;
                string[] productsQuantity = productsQuantities.Split(' ');
                int counter = 0;

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
                            if (product.Quantity < int.Parse(productsQuantity[counter]))
                            {
                                LabelController.ChangeLabelText(ref label6, "Количеството на продукта " + product.Name + " не достига.");
                                return;
                            }
                        }
                        else
                        {
                            LabelController.ChangeLabelText(ref label6, "Въведеният продукт " + productName + " не е наличен.");
                            return;
                        }
                        counter++;
                    }

                    FormToDBController.EditDishInDataBase(ref controller, dName, dPrice, dWeight, productsInDish, productsQuantities);
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
            new ManagerHome(controller).Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void menuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemName.Text = menuItems.SelectedItem.ToString();
            menuItemsParameters.SetSelected(menuItems.SelectedIndex, true);
            itemPrice.Text = menuItemsParameters.SelectedItem.ToString().Split(' ')[0];
            products.Text = menuItemsParameters.SelectedItem.ToString().Split(' ')[1].Replace(",", " ");
            productQuantities.Text = menuItemsParameters.SelectedItem.ToString().Split(' ')[2].Replace(",", " ");
            itemWeight.Text = menuItemsParameters.SelectedItem.ToString().Split(' ')[3];
        }
    }
}
