using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem
{
    public class ProductsList : List<Product>
    {
        List<Product> products { get; set; }
        public String toString()
        {
            string text = string.Join(";", products);
            return text;
        }

    }
}
