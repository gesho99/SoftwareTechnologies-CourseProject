using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantSystem.Controllers;
using RestaurantSystem.Views;

namespace RestaurantSystem
{
    public partial class ManagerHome : Form
    {
        DBController controller;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public ManagerHome(DBController controller)
        {
            this.controller = controller;
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void Table_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tables(), sender);
            //new Tables().Show();
            //this.Hide();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddUser(controller), sender);
            // new AddUser(controller).Show();
            // this.Hide();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagerProfile(), sender);
            // new ManagerProfile().Show();
            // this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
           OpenChildForm(new Menu(controller), sender);
            //new Menu(controller).Show();
            //this.Hide();

        }

        private void Stock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductsInStockForm(controller), sender);
            // new ProductsInStockForm(controller).Visible = true;
            //this.Hide();
        }

        private void Delivery_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Deliveries(controller), sender);
            // new Deliveries(controller).Show();
            // this.Hide();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountingForm(controller), sender);
            // new AccountingForm(controller).Show();
            // this.Hide();
        }
    }
}
