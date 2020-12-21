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

        public ICollection<DishProducts2> DishProducts2 { get; set; } = new HashSet<DishProducts2>();

        public ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();

        public ICollection<DeliveryProducts2> DeliveryProducts2 { get; set; } = new HashSet<DeliveryProducts2>();

    }
}
