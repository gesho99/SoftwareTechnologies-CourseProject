using RestaurantSystem.Controllers;
using RestaurantSystem.Data;
using RestaurantSystem.Migrations;
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

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantDbContext, Configuration>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Deliveries(controller));
            Application.Run(new Menu(controller));

        }
    }
}
