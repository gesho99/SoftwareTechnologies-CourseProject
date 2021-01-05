using RestaurantSystem.Controllers;
using RestaurantSystem.Data;
using RestaurantSystem.Migrations;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
               
            Controller controller = new Controller();            
            controller.CreateDB();
            controller.CreateRoles();
            controller.CreateAdminEmployer();
            controller.CreateAdminAccount();

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantDbContext, Configuration>());

            //controller.CreateRoles();
            //controller.CreateAdminEmployer();
            //controller.CreateAdminAccount();
            controller.AddDelivery();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AccountingForm(controller));
            //Application.Run(new Deliveries(controller));                 
            Application.Run(new ProductsInStockForm(controller));
            //Application.Run(new Login());
        }
    }
}
