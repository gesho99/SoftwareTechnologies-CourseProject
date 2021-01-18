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
using RestaurantSystem.Views;

namespace RestaurantSystem
{
    public partial class Deliveries : Form
    {
        DBController controller;

        public Deliveries(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadDeliveries();
        }

        public void LoadDeliveries()
        {
            ListBoxController.ClearItems(ref waitingDeliveries);
            ListBoxController.ClearItems(ref approvedDeliveries);

            ICollection<Delivery> deliveries = FormToDBController.LoadDeliveriesFromDataBase(ref controller);

            string deliveryProducts = null;

            foreach (Delivery dl in deliveries)
            {
                ICollection<Product> products = FormToDBController.GetDeliveryProductsFromDataBase(ref controller,dl.Id);
                foreach (Product product in products)
                {
                    deliveryProducts += product.Name + " - " + product.Quantity + " ";
                }
                if (dl.Approved)
                {
                    ListBoxController.AddListBoxDeliveries(ref approvedDeliveries,deliveryProducts,dl.DeliveryQuantity,dl.DeliveryPrice,dl.Supplier.Name);
                }
                else
                {
                    ListBoxController.AddListBoxDeliveries(ref waitingDeliveries, deliveryProducts, dl.DeliveryQuantity, dl.DeliveryPrice, dl.Supplier.Name);
                }
                deliveryProducts = null;
            }
        }

        private void LoadTheme()
        {
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
            label1.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            DeliveryQuantity.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label17.ForeColor = ThemeColor.PrimaryColor;

        }

        private bool DeliveryValidation()
        {
            try
            {
                String pName = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                string dSupplier = deliverySupplier.Text;

                if (pQuantity <= 5)
                {                    
                    LabelController.ChangeLabelText(ref label2, "Моля въведете количество по - голямо 5");
                    return false;
                }
                else if (pName.Length < 2|| dSupplier.Length < 3)
                {
                    LabelController.ChangeLabelText(ref label2, "Моля въведете валидно име на продукт / доставчик");

                    return false;
                }               
                else
                {                   
                    return true;
                }
            }
            catch (FormatException)
            {
                LabelController.ChangeLabelText(ref label2, "Моля въведете валидни данни.");
                return false;
            }
            catch (OverflowException)
            {
                LabelController.ChangeLabelText(ref label2, "Моля въведете валидни данни.");
                return false;
            }

        }

        private void addDelivery_Click(object sender, EventArgs e)
        {
            if (DeliveryValidation() == true)
            {
                string name = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                string dSupplier = deliverySupplier.Text;

                String[] items1 = waitingDeliveries.ToString().Split(',', '-', ' ');
                if (items1.Contains(name))
                {
                    LabelController.ChangeLabelText(ref label2, "Вече има такъв продукт в неодобрените доставки");
                }
                else if (items1.Contains(dSupplier))
                {
                    LabelController.ChangeLabelText(ref label2, "Вече има такъв доствчик в неодобрените доствки");
                }
                else
                {
                    String[] items2 = approvedDeliveries.ToString().Split(',', '-', ' ');
                    if (items2.Contains(name))
                    {
                        LabelController.ChangeLabelText(ref label2, "Вече има такъв продукт в одобрените доставки");
                    }
                    else if (items2.Contains(dSupplier))
                    {
                        LabelController.ChangeLabelText(ref label2, "Вече има доставчик вече е одобрен");
                    }
                    else
                    {
                        FormToDBController.AddDeliveryInDataBase(ref controller,name, pQuantity, dSupplier);
                        LoadDeliveries();
                    }
                }
                
            }
        }

        private void editDelivery_Click(object sender, EventArgs e)
        {          
            if (DeliveryValidation() == true)
            {

                string[] items = waitingDeliveries.Text.Split(' ', ',', '-');
                string name = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                string dSupplier = deliverySupplier.Text;
                
                if (items.Count()!=1)
                {
                    if (!(items.Last() == dSupplier))
                    {
                        LabelController.ChangeLabelText(ref label2, "Този доставчик не съществува.");                      
                    }
                    else if (!(items.Contains(name)))
                    {
                        LabelController.ChangeLabelText(ref label2, "Този продукт не съществува.");
                    }
                    else
                    {
                        controller.EditDelivery(name, pQuantity, dSupplier);
                        LoadDeliveries();
                    }
                }
                else
                {
                    LabelController.ChangeLabelText(ref label2, "Изберете поръчка от неодобрените");
                }
            }
        }

        public void approveDeliveryButton_Click(object sender, EventArgs e)
        {
            string[] items = waitingDeliveries.Text.Split(' ', ',', '-');
            string dSupplier = deliverySupplier.Text;

            if (items.Count() != 1)
            {
                if (!(items.Last() == dSupplier))
                {
                    LabelController.ChangeLabelText(ref label2, "Този доставчик не съществува в неодобрените поръчки.");
                }               
                else
                {
                    FormToDBController.ApproveDeliveryInDataBase(ref controller,dSupplier);
                    LoadDeliveries();
                }
            }
            else
            {
                LabelController.ChangeLabelText(ref label2, "Изберете поръчка");
            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ManagerHome(controller).Show();
            this.Hide();
        }   

        private void Deliveries_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            new AddSupplier(controller).Show();
            this.Hide();
        }

    }
}



