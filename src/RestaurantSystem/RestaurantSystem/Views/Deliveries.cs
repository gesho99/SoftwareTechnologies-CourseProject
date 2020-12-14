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
    public partial class Deliveries : Form
    {
        Controller controller;

        public Deliveries(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadDeliveries();
        }

        public void LoadDeliveries()
        {
            waitingDeliveries.Items.Clear();

            ICollection<Delivery> Deliveries = controller.LoadDeliveries();

            foreach (Delivery delivery in Deliveries)
            {
                waitingDeliveries.Items.Add(
                    delivery.Products + " " +
                    delivery.DeliveryQuantity + " " +
                    delivery.DeliveryPrice + " " +
                    delivery.Supplier);
            }
        }

        private bool DeliveryValidation()
        {
            try
            {
                String pName = productName.Text;
                int dQuantity = int.Parse(productQuantity.Text);
                double dPrice = double.Parse(deliveryPrice.Text);
                string dSupplier = deliverySupplier.Text;
                label2.Visible = false;
            

                if (dQuantity <= 0)
                {
                    label2.Text = "Моля въведете количество по - голямо от нула";
                    return false;
                }
                else if (pName.Length < 3 || dSupplier.Length < 3)
                {
                    label2.Text = "Моля въведете валидно име на продукт / доставчик";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                label2.Text = "Моля въведете валидни данни.";
                return false;
            }
            catch (OverflowException)
            {
                label2.Text = "Моля въведете валидни данни.";
                return false;
            }
        
        }
    

        private void editDelivery_Click(object sender, EventArgs e)
        {
            if (DeliveryValidation() == true)
            {
                ICollection<Product> deliveryProducts = new HashSet<Product>();
                String[] productsInDelivery = productName.Text.Split(' ');
                int dQuantity = int.Parse(productQuantity.Text);
                double dPrice = double.Parse(deliveryPrice.Text);
                string dSupplier = deliverySupplier.Text;

                if (!waitingDeliveries.Items.Contains(productsInDelivery) || !waitingDeliveries.Items.Contains(dQuantity) || !waitingDeliveries.Items.Contains(dSupplier))
                {
                    label2.Visible = true;
                    label11.Text = "Тази поръчка не съществува.";
                }
                else
                {
                    foreach (String deliveryProduct in productsInDelivery)
                    {
                        Product product = controller.SelectProductByName(deliveryProduct);

                        if (product != null)
                        {
                            deliveryProducts.Add(product);
                        }
                        else
                        {
                            label2.Text = "Въведените продукти " + productName + " не са наличен.";
                            return;
                        }
                    }
                }


            }
        }

        public void approveDeliveryButton_Click(object sender, EventArgs e)
        {
            ICollection<Product> deliveryProducts = new HashSet<Product>();
            String[] productsInDelivery = productName.Text.Split(' ');
            int dQuantity = int.Parse(productQuantity.Text);
            double dPrice = double.Parse(deliveryPrice.Text);
            string dSupplier = deliverySupplier.Text;

            if (!waitingDeliveries.Items.Contains(deliveryProducts))
            {
                label2.Text = "Поръчката, която се опитвате да одобрите не съществува ";
            }
            else
            {
                waitingDeliveries.Items.Remove(
                    deliveryProducts.ToString() + " " +
                    dQuantity + " " +
                    dPrice + " " +
                    dSupplier);

                controller.ApproveDelivery(dQuantity, deliveryProducts);

                approvedDeliveries.Items.Add(
                    deliveryProducts.ToString() + " " +
                    dQuantity + " " +
                    dPrice + " " +
                    dSupplier);
            }
        }
    }
}



