using RestaurantSystem.Data;
using RestaurantSystem.Data.Models;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Controllers
{
    public class Controller
    {
        RestaurantDbContext db;
        public void CreateDB()
        {
            db = new RestaurantDbContext();
            db.Database.CreateIfNotExists();
        }

        public void AddProduct(string name, int quantity, double price, double dlprice)
        {
            db.Products.Add(new Product
            {
                Name = name,
                Quantity = quantity,
                Price = price,
                DeliveryPrice = dlprice
            });

            db.SaveChanges();
        }

        public ICollection<Product> LoadProducts()
        {
            return db.Products
                .Select(p => p)
                .ToArray();
        }

        public void EditProduct(string name, int quantity, double price, double dlprice)
        {
            Product product = db.Products.SingleOrDefault(p => p.Name == name);
            if(product != null)
            {
                product.Name = name;
                product.Quantity = quantity;
                product.Price = price;
                product.DeliveryPrice = dlprice;

                db.SaveChanges();
            }
        }

        public Product SelectProductByName(string name)
        {
            Product product = db.Products.SingleOrDefault(p => p.Name == name);
            return product;
        }

        public void AddDish(string dName, double dPrice, double dWeight, ICollection<Product> productsInDish)
        {
            Dish dish = new Dish
            {
                DishName = dName,
                DishPrice = dPrice,
                DishWeight = dWeight,
                Products = productsInDish
            };
            
            db.Dishes.Add(dish);

            foreach(Product product in productsInDish)
            {
                product.Dishes.Add(dish);
            }

            db.SaveChanges();
        }

        public Dish SelectDishByName(string name)
        {
            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == name);
            return dish;
        }

        public ICollection<Dish> LoadDishes()
        {
            return db.Dishes
                .Select(d => d)
                .ToArray();
        }

        public void EditDish(string dName, double dPrice, double dWeight, ICollection<Product> productsInDish)
        {
            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == dName);
            if(dish != null)
            {
                dish.DishPrice = dPrice;
                dish.DishWeight = dWeight;
                
                foreach(Product product in dish.Products)
                {
                    product.Dishes.Remove(dish);
                }
                
                dish.Products = null;

                db.SaveChanges();

                AddProductsToDish(dish, productsInDish);
            }
        }

        public void AddProductsToDish(Dish dish, ICollection<Product> productsInDish)
        {

            dish.Products = productsInDish;
            foreach(Product product in dish.Products){
                product.Dishes.Add(dish);
            }
        }

        public bool RemoveDish(string dName)
        {

            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == dName);
            if (dish != null)
            {
                db.Dishes.Remove(dish);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddElectricityExpense(string dateString, double elValue)
        {
            db.Expenses.Add(new Expenses
            {
                Name = "Ток",
                Value = elValue,
                ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                                System.Globalization.CultureInfo.InvariantCulture)
            });
        }

        public void AddWaterExpense(string dateString, double wValue)
        {
            db.Expenses.Add(new Expenses
            {
                Name = "Вода",
                Value = wValue,
                ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                                System.Globalization.CultureInfo.InvariantCulture)
            });
        }

        public void AddInternetExpense(string dateString, double iValue)
        {
            db.Expenses.Add(new Expenses
            {
                Name = "Интернет",
                Value = iValue,
                ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                               System.Globalization.CultureInfo.InvariantCulture)
            });

            db.SaveChanges();
        }

    }
}
