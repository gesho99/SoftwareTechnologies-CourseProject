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

        [MaxLength(30)]
        public string DishCategory { get; set; }

        [Required]
        public double DishPrice { get; set; }

        [Required]
        public double DishWeight { get; set; }

        public ICollection<EmployerReport> EmployerReports { get; set; } = new HashSet<EmployerReport>();

        public ICollection<DishProducts> DishProducts { get; set; } = new HashSet<DishProducts>();

    }
}
