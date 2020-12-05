using RestaurantSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class Product
    {

        public int Id { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double DeliveryPrice { get; set; }

        public ICollection<Dish> Dishes { get; set; } = new HashSet<Dish>();

    }
}
