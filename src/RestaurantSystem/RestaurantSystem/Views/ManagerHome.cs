using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            btnCloseChildForm.Visible = false;
          
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
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
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
            OpenChildForm(new ManagerTables(controller), sender);
            //new ManagerTables().Show();
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

      
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "НАЧАЛО";
            panelTitleBar.BackColor = Color.FromArgb(255, 51, 0);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void addUser_MouseEnter(object sender, EventArgs e)
        {
            addUser.ForeColor = Color.Black;
        }

        private void addUser_MouseLeave(object sender, EventArgs e)
        {
            addUser.ForeColor = Color.White;
        }

        private void employees_MouseEnter(object sender, EventArgs e)
        {
            employees.ForeColor = Color.Black;
        }

        private void employees_MouseLeave(object sender, EventArgs e)
        {
            employees.ForeColor = Color.White;
        }

        private void table_MouseEnter(object sender, EventArgs e)
        {
            table.ForeColor = Color.Black;
        }

        private void table_MouseLeave(object sender, EventArgs e)
        {
            table.ForeColor = Color.White;
        }

        private void menu_MouseEnter(object sender, EventArgs e)
        {
            menu.ForeColor = Color.Black;
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.ForeColor = Color.White;
        }

        private void stock_MouseEnter(object sender, EventArgs e)
        {
            stock.ForeColor = Color.Black;
        }

        private void stock_MouseLeave(object sender, EventArgs e)
        {
            stock.ForeColor = Color.White;
        }

        private void delivery_MouseEnter(object sender, EventArgs e)
        {
            delivery.ForeColor = Color.Black;
        }

        private void delivery_MouseLeave(object sender, EventArgs e)
        {
            delivery.ForeColor = Color.White;
        }

        private void accounting_MouseEnter(object sender, EventArgs e)
        {
            accounting.ForeColor = Color.Black;
        }

        private void accounting_MouseLeave(object sender, EventArgs e)
        {
            accounting.ForeColor = Color.White;
        }
    }
}
