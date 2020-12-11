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
            approvedDeliveries.Items.Clear();
            ICollection<Delivery> Deliveries = controller.LoadDeliveries();
          
            foreach (Delivery delivery in Deliveries)
            {
                waitingDeliveries.Items.Add(delivery.Products + " " + delivery.DeliveryQuantity + " " + delivery.DeliveryPrice + " " + delivery.DeliveryDate);
            }                
        }

        private bool DeliveryValidation()
        {
            try
            {
                String pName= productName.Text;
                double pPrice = double.Parse(productPrice.Text);
                int dQuantity = int.Parse(productQuantity.Text);
                double dPrice = double.Parse(deliveryPrice.Text);
                string dSupplier = deliverySupplier.Text;
                label2.Visible = false;

                if (pPrice <= 0)
                {
                    label2.Text = "Моля въведете цена на продукта по - голяма от нула";
                    return false;
                }
                else if (dPrice <= 0)
                {
                    label2.Text = "Моля въведете цена за доставка по - голяма от нула";
                    return false;
                }
                else if (dQuantity <= 0)
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


        private void addDelivery_Click(object sender, EventArgs e)
        {
            if (DeliveryValidation() == true)
            {                
                ICollection<Product> deliveryProducts = new HashSet<Product>();
                String[] productsInDelivery = productName.Text.Split(' ');
                int dQuantity = int.Parse(productQuantity.Text);
                double dPrice = double.Parse(deliveryPrice.Text);
                string dSupplier = deliverySupplier.Text;
                Supplier supplier = new Supplier();

                
                foreach (String productName in productsInDelivery)
                {
                    Product product = controller.SelectProductByName(ProductName);
                   
                    if (product !=null)
                    {
                        deliveryProducts.Add(product);
                        productPrice.Text = product.Price.ToString();
                    }
                    else
                    {
                        label2.Text = "Въведеният продукт " + productName + " не е наличен.";
                        return;
                    }
                    
                }
                if (waitingDeliveries.Items.Contains(productsInDelivery))
                {
                    label2.Visible = true;
                    label11.Text = "Тази поръчка вече е добавена. Ако искате да я редактирате или одобрите, моля натиснете съответния бутон.";
                }
                else
                {
                    supplier.Name = deliverySupplier.Text;
                    controller.AddDelivery(dQuantity, dPrice, supplier,deliveryProducts);
                    LoadDeliveries();
                }

            }
        }

        private void editDelivery_Click(object sender, EventArgs e)
        {

        }

        private void approveDeliveryButton_Click(object sender, EventArgs e)
        {
            ICollection<Product> deliveryProducts = new HashSet<Product>();
            String[] productsInDelivery = productName.Text.Split(' ');
            int dQuantity = int.Parse(productQuantity.Text);
            double dPrice = double.Parse(deliveryPrice.Text);
            string dSupplier = deliverySupplier.Text;
            Supplier supplier = new Supplier();

            if (waitingDeliveries.Items.Contains(deliveryProducts))
            {
                label2.Text = "Поръчката, която се опитвате да одобрите не съществува ";
            }
            else
            {
                controller.ApproveDelivery(dQuantity, dPrice, supplier, deliveryProducts);
            }
        }
    }
}
