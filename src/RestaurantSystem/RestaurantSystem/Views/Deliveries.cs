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
            LoadWaitingDeliveries();
            LoadApprovedDeliveries();
        }

        public void LoadWaitingDeliveries()
        {
            waitingDeliveries.Items.Clear();

            ICollection<Delivery> deliveries = controller.LoadDeliveries();
                        
            string st = null;

            foreach (Delivery delivery in deliveries)
            {
                
                ICollection<Product> products = controller.GetDeliveryProducts(delivery.Id);
                if (delivery.Approved == false)
                {
                    foreach (Product product in products)
                    {
                        st += product.Name + " - " + product.Quantity + " ";
                    }
                    if (st != null)
                    {
                        st += delivery.DeliveryQuantity + ", " + delivery.DeliveryPrice + ", " + delivery.Supplier.Name;
                        waitingDeliveries.Items.Add(st);
                        st = null;
                    }
                }                               
            } 
                
        }

        public void LoadApprovedDeliveries()
        {
            approvedDeliveries.Items.Clear();

            ICollection<Delivery> deliveries = controller.LoadDeliveries();

            string st = null;
            
            foreach (Delivery delivery in deliveries)
            {
                if (delivery.Approved==true)
                {
                    ICollection<Product> products = controller.GetDeliveryProducts(delivery.Id);
                    if (delivery.Approved == true)
                    {
                        foreach (Product product in products)
                        {
                            st += product.Name + " - " + product.Quantity + " ";
                        }
                        if (st != null)
                        {
                            st += delivery.DeliveryQuantity + ", " + delivery.DeliveryPrice + ", " + delivery.Supplier.Name;
                            approvedDeliveries.Items.Add(st);
                            st = null;
                        }
                    }

                }
            }
        }

        private bool DeliveryValidation()
        {
            try
            {
                String pName = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                int dQuantity = int.Parse(approvedQuantity.Text);
                string dSupplier = deliverySupplier.Text;
                label2.Visible = false;

                if (pQuantity <= 0)
                {
                    if (dQuantity > 0)
                    {
                        return true;
                    }
                    label2.Visible = true;
                    label2.Text = "Моля въведете количество по - голямо от нула";                  
                    return false;
                }
                else if (dQuantity <= 0)
                {
                    if (pQuantity > 0)
                    {
                        return true;
                    }
                    label2.Visible = true;
                    label2.Text = "Моля въведете количество за одобрение по - голямо от нула";
                    return false;
                }
                else if (pName.Length < 2|| dSupplier.Length < 3)
                {
                    label2.Visible = true;
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
            label2.Visible = false;
           
            if (DeliveryValidation() == true)
            {

                string[] items = waitingDeliveries.Text.Split(' ', ',', '-');
                string name = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                string dSupplier = deliverySupplier.Text;
                
                if (!(items.Count()==1))
                {
                    if (!(items.Contains(dSupplier)))
                    {
                        label2.Visible = true;
                        label2.Text = "Този доставчик не съществува.";
                    }
                    else if (!(items.Contains(name)))
                    {                       
                        label2.Visible = true;
                        label2.Text = "Този продукт не съществува.";
                    }
                    else
                    {
                        controller.EditDelivery(name, pQuantity, dSupplier);
                        LoadWaitingDeliveries();
                        LoadApprovedDeliveries();
                    }
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "Изберете поръчка";
                }
            }
        }

       public void approveDeliveryButton_Click(object sender, EventArgs e)
       {
            label2.Visible = false;

            if (DeliveryValidation() == true)
            {

                string[] items = waitingDeliveries.Text.Split(' ', ',', '-');
                string name = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                string dSupplier = deliverySupplier.Text;

                if (!(items.Count() == 1))
                {
                    if (!(items.Contains(dSupplier)))
                    {
                        label2.Visible = true;
                        label2.Text = "Този доставчик не съществува.";
                    }
                    else if (!(items.Contains(name)))
                    {
                        label2.Visible = true;
                        label2.Text = "Този продукт не съществува.";
                    }
                    else
                    {
                        controller.ApproveDelivery(name, pQuantity, dSupplier);
                        LoadWaitingDeliveries();
                        LoadApprovedDeliveries();
                    }
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "Изберете поръчка";
                }
            }
        }        

        private void BackButton_Click(object sender, EventArgs e)
        {
            new HomeAdmin(controller).Show();
            this.Hide();
        }
    }
}



