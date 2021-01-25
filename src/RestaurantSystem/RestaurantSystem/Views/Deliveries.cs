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
                    ListBoxController.AddListBoxDeliveries(ref approvedDeliveries,deliveryProducts +" дата: " +dl.DeliveryDate, dl.DeliveryQuantity,dl.DeliveryPrice,dl.Supplier.Name);
                }
                else
                {
                    ListBoxController.AddListBoxDeliveries(ref waitingDeliveries, deliveryProducts ,dl.DeliveryQuantity, dl.DeliveryPrice, dl.Supplier.Name);
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
                LabelController.ChangeLabelVisibility(ref label2, true);

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
                string pName = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                string dSupplier = deliverySupplier.Text;
                Product product = FormToDBController.SelectProductByNameFromDataBase(ref controller, pName);
                Supplier supplier = FormToDBController.SelecetSupprlierByName(ref controller, dSupplier);

                if (product != null)
                {
                    if (supplier !=null)
                    {
                        LabelController.ChangeLabelVisibility(ref label2, false);
                        FormToDBController.AddDeliveryInDataBase(ref controller, pName, pQuantity, dSupplier);
                        LoadDeliveries();
                    }
                    else
                    {
                        LabelController.ChangeLabelVisibility(ref label2, true);
                        LabelController.ChangeLabelText(ref label2, "Този доставчик не съществува.");
                    }
                }
                else
                {
                    LabelController.ChangeLabelVisibility(ref label2, true);
                    LabelController.ChangeLabelText(ref label2, "Този продукт не съществува.");
                }
            }
        }

        private void editDelivery_Click(object sender, EventArgs e)
        {          
            if (DeliveryValidation() == true)
            {

                string[] items = waitingDeliveries.Text.Split(',', '-',':');
                string name = productName.Text;
                int pQuantity = int.Parse(productQuantity.Text);
                string dSupplier = deliverySupplier.Text;
                Product product = FormToDBController.SelectProductByNameFromDataBase(ref controller,name);
                
                if (!(waitingDeliveries.SelectedIndex == -1))
                {
                    if (!(items.First() == dSupplier))
                    {
                        LabelController.ChangeLabelVisibility(ref label2, true);
                        LabelController.ChangeLabelText(ref label2, "Този доставчик не е за избраната поръчка.");                      
                    }
                    else if (product ==null)
                    {
                        LabelController.ChangeLabelVisibility(ref label2, true);
                        LabelController.ChangeLabelText(ref label2, "Този продукт не съществува");
                    }
                    else
                    {
                        LabelController.ChangeLabelVisibility(ref label2, false);
                        controller.EditDelivery(name, pQuantity, dSupplier);
                        LoadDeliveries();
                    }
                }
                else
                {
                    LabelController.ChangeLabelVisibility(ref label2, true);
                    LabelController.ChangeLabelText(ref label2, "Изберете поръчка от неодобрените");
                }
            }
        }

        public void approveDeliveryButton_Click(object sender, EventArgs e)
        {
            string[] items = waitingDeliveries.Text.Split(',', '-',':');
            string dSupplier = deliverySupplier.Text;

            if (!(waitingDeliveries.SelectedIndex == -1))
            {               
                if (!(items.First() == dSupplier))
                {
                    LabelController.ChangeLabelVisibility(ref label2, true);
                    LabelController.ChangeLabelText(ref label2, "Грешен достачик.");
                }               
                else
                {
                    double dQuantity = double.Parse(items[2]);
                    LabelController.ChangeLabelVisibility(ref label2, false);
                    FormToDBController.ApproveDeliveryInDataBase(ref controller,dSupplier,dQuantity);
                    LoadDeliveries();
                }
            }
            else
            {
                LabelController.ChangeLabelVisibility(ref label2, true);
                LabelController.ChangeLabelText(ref label2, "Изберете поръчка от неодобрените.");
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



