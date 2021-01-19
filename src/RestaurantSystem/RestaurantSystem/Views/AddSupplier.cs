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

namespace RestaurantSystem.Views
{
    public partial class AddSupplier : Form
    {
        DBController controller;

        public AddSupplier(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadSuppliers();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
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
            label5.ForeColor = ThemeColor.PrimaryColor;
        }
        private bool SupplierValidation(string spName, string spPhone, string spAvailableDays)
        {
            try
            {
                LabelController.ChangeLabelVisibility(ref label4, false);
                LabelController.ChangeLabelText(ref label4, "");
                string supplierName = spName;
                string supplierPhone = spPhone;
                string supplierAvailableDays = spAvailableDays;

                if (supplierName.Length < 3)
                {
                    LabelController.ChangeLabelVisibility(ref label4, true);
                    LabelController.ChangeLabelText(ref label4, "Моля въведете валидно на доставчик.");
                    return false;
                }
                else if (!(supplierPhone.Length == 10))
                {
                    LabelController.ChangeLabelVisibility(ref label4, true);
                    LabelController.ChangeLabelText(ref label4, "Моля въведете валиден телефон");
                    return false;
                }
                else if (supplierAvailableDays.Length < 5)
                {
                    LabelController.ChangeLabelVisibility(ref label4, true);
                    LabelController.ChangeLabelText(ref label4, "Моля въведете валидни дни от седмицата");
                    return false;
                }
                else if (supplierAvailableDays.Length > 5)
                {
                    String[] daysOfWeek = new[] {
                        "понеделник",
                        "вторник",
                        "сряда",
                        "четвъртък",
                        "петък",
                        "събота",
                        "неделя" };

                    String[] availableDays = supplierAvailableDays.Split(',');
                    foreach (var day in availableDays)
                    {
                        for (int i = 0; i < daysOfWeek.Length; i++)
                        {
                            if (!(daysOfWeek.Contains(day)))
                            {
                                LabelController.ChangeLabelVisibility(ref label4, true);
                                LabelController.ChangeLabelText(ref label4, "Моля въведете валидни дни от седмицата");
                                return false;
                            }                          
                        }
                    }

                    return true;
                }           
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                LabelController.ChangeLabelVisibility(ref label4, true);
                LabelController.ChangeLabelText(ref label4, "Моля въведете валидни данни.");
                return false;
            }
            catch (OverflowException)
            {
                LabelController.ChangeLabelVisibility(ref label4, true);
                LabelController.ChangeLabelText(ref label4, "Моля въведете валидни данни.");
                return false;
            }
        }

        private void LoadSuppliers()
        {
            ListBoxController.ClearItems(ref suppliersList);

            ICollection<Supplier> suppliers = FormToDBController.LoadSuppliersFromDataBase(ref controller);

            foreach (Supplier sp in suppliers)
            {
                ListBoxController.AddListBoxSuppliers(ref suppliersList, sp.Name,sp.PhoneNumber,sp.AvailableDays);
            }
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            if (SupplierValidation(supplierName.Text, supplierPhone.Text, supplierAvailableDays.Text) == true)
            {
                string spName = supplierName.Text;
                string spPhone = supplierPhone.Text;
                string spAvailableDays = supplierAvailableDays.Text;

                if (suppliersList.Items.Contains(spName))
                {
                    LabelController.ChangeLabelVisibility(ref label4, true);
                    LabelController.ChangeLabelText(ref label4, "Този доставчик вече е добавен.");
                }
                else
                {
                    FormToDBController.AddSupplierInDataBase(ref controller, spName, spPhone,spAvailableDays);
                    ListBoxController.AddListBoxSuppliers(ref suppliersList, spName, spPhone, spAvailableDays);
                }
            }
        }

        private void editSupplier_Click(object sender, EventArgs e)
        {
            if (SupplierValidation(supplierName.Text, supplierPhone.Text, supplierAvailableDays.Text) == true)
            {
                string spName = supplierName.Text;
                string spPhone = supplierPhone.Text;
                string spAvailableDays = supplierAvailableDays.Text;

                if (suppliersList.Items.Contains(spName))
                {
                    LabelController.ChangeLabelVisibility(ref label4, true);
                    LabelController.ChangeLabelText(ref label4, "Този доставчик вече е добавен.");
                }
                else
                {
                    FormToDBController.EditSupplierInDataBase(ref controller, spName, spPhone, spAvailableDays);
                    LoadSuppliers();
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            new Deliveries(controller).Show();
            this.Close();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
