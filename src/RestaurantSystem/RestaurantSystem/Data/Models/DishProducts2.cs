using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class DishProducts2
    {

        public int DishId { get; set; }

        public Dish Dish { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}
