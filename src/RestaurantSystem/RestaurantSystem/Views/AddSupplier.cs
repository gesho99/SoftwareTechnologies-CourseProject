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
            String[] availableDays = supplierAvailableDays.Text.Split(',', ' ');
            String[] daysOfWeek = new[] {
                        "понеделник",
                        "вторник",
                        "сряда",
                        "четвъртък",
                        "петък",
                        "събота",
                        "неделя" };

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
                else if (!(supplierPhone.Length == 10 || supplierPhone.Length==9))
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
                else if (!daysOfWeek.Contains(availableDays[0]))
                {
                    bool check = false;
                    foreach (var day in availableDays)
                    {
                        if (day.Length >= 5)
                        {                           
                            if (!daysOfWeek.Contains(day))
                            {
                                check = false;
                            }
                            else
                            {
                                check = true;
                            }
                        }
                    }

                    if (!check)
                    {
                        LabelController.ChangeLabelVisibility(ref label4, true);
                        LabelController.ChangeLabelText(ref label4, "Моля въведете валидни дни от седмицата");
                    }

                    return check;
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
                Supplier supplier = FormToDBController.SelecetSupprlierByName(ref controller, spName);

                if (supplier == null)
                {
                    FormToDBController.AddSupplierInDataBase(ref controller, spName, spPhone, spAvailableDays);
                    LoadSuppliers();
                }
                else
                {
                    LabelController.ChangeLabelVisibility(ref label4, true);
                    LabelController.ChangeLabelText(ref label4, "Този доставчик вече е добавен.");
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
                    LabelController.ChangeLabelVisibility(ref label4, false);
                    FormToDBController.EditSupplierInDataBase(ref controller, spName, spPhone, spAvailableDays);
                    LoadSuppliers();
                }
            }
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void deleteSupplier_Click(object sender, EventArgs e)
        {
            string[] items = suppliersList.Text.Split(',', '-');
            string spName = items.First();

            if (suppliersList.SelectedIndex == -1)
            {
                LabelController.ChangeLabelVisibility(ref label4, true);
                LabelController.ChangeLabelText(ref label4, "Изберете доствчик за премахване");
            }
            else
            {
                LabelController.ChangeLabelVisibility(ref label4, true);
                LabelController.ChangeLabelText(ref label4, "Премахнаха се и доставките свъразни с достачика");
                FormToDBController.DeleteSupplierFromDataBase(ref controller, spName);
                LoadSuppliers();
            }
        }

        private void suppliersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameOfSupplier = "";
            
            foreach(char c in suppliersList.SelectedItem.ToString())
            {
                if(c == ',')
                {
                    break;
                }
                nameOfSupplier += c;
            }

            Supplier supplier = FormToDBController.SelecetSupprlierByName(ref controller, nameOfSupplier);

            supplierName.Text = supplier.Name;
            supplierAvailableDays.Text = supplier.AvailableDays;
            supplierPhone.Text = supplier.PhoneNumber;
        }
    }
}
