using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class Dish
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string DishName { get; set; }

        [Required]
        public double DishSellingPrice { get; set; }

        [Required]
        public double DishMakingPrice { get; set; }

        [Required]
        public string ProductsQuantity { get; set; }

        [Required]
        public double DishWeight { get; set; }

        public ICollection<DishEmployerReports> DishEmployerReports { get; set; } = new HashSet<DishEmployerReports>();

        public ICollection<DishProducts> DishProducts { get; set; } = new HashSet<DishProducts>();

    }
}
