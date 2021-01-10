using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class DishProducts
    {

        public virtual  Product Product { get; set; }

        public int ProductId { get; set; }

        public virtual Dish Dish { get; set; }

        public int DishId { get; set; }

    }
}
