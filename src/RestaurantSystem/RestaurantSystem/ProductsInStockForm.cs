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
    public partial class ProductsInStockForm : Form
    {
        public ProductsInStockForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label11.Visible = false;
                label11.Text = "";
                List<string> existingProducts = new List<string>();
                int quantity = int.Parse(productQuantity.Text);
                int prPrice = int.Parse(productPrice.Text);
                int dlPrice = int.Parse(deliveryPrice.Text);
                string prName = productName.Text;

                if (quantity <= 0)
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете количество по-голямо от нула.";
                }
                else if(prPrice < 0)
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете цена на продукта по - голяма или равна на нула.";
                }
                else if(dlPrice < 0)
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете доставна цена по - голяма или равна на нула.";
                }
                else if(prName == "")
                {
                    label11.Visible = true;
                    label11.Text = "Моля въведете името на продукта.";
                }
                else if (existingProducts.Contains(prName))
                {
                    label11.Visible = true;
                    label11.Text = "Този продукт вече е добавен. Ако искате да го редактирате моля натиснете бутона редактирай.";
                }
                else
                {
                    existingProducts.Add(prName);
                    ItemsInStock.Items.Add(productName.Text + " " + quantity + "бр. " + prPrice + "лв/бр " + dlPrice + "лв/д");
                }
            }
            catch (FormatException)
            {
                label11.Visible = true;
                label11.Text = "Моля въведете валидни данни.";
            }
            catch (OverflowException)
            {
                label11.Visible = true;
                label11.Text = "Моля въведете валидни данни.";
            }
        }
    }
}
