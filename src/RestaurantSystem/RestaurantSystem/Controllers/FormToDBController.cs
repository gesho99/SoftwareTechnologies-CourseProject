using RestaurantSystem.Data.Models;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Controllers
{
    public static class FormToDBController
    {
        public static ICollection<Product> LoadProductsFromDataBase(ref DBController controller)
        {
            return controller.LoadProducts();
        }

        public static void AddProductInDataBase(ref DBController controller, string prName, int quantity, double prPrice, double dlPrice)
        {
            controller.AddProduct(prName, quantity, prPrice, dlPrice);
        }

        public static void EditProductInDataBase(ref DBController controller, string prName, int quantity, double prPrice, double dlPrice)
        {
            controller.EditProduct(prName, quantity, prPrice, dlPrice);
        }

        public static ICollection<Dish> LoadDishesFromDataBase(ref DBController controller)
        {
            return controller.LoadDishes();
        }

        public static void AddDishesToDataBase(ref DBController controller, string dName, double dPrice, double dWeight, ICollection<Product> productsInDish)
        {
            controller.AddDish(dName, dPrice, dWeight, productsInDish);
        }

        public static void EditDishInDataBase(ref DBController controller, string dName, double dPrice, double dWeight, ICollection<Product> productsInDish)
        {
            controller.EditDish(dName, dPrice, dWeight, productsInDish);
        }

        public static Product SelectProductByNameFromDataBase(ref DBController controller, string productName)
        {
            return controller.SelectProductByName(productName);
        }

    }
}
