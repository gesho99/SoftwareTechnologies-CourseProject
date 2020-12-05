using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class RestaurantMenu
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string DishName { get; set; }

        [Required]
        public double DishPrice { get; set; }

        [Required]
        public double DishWeight { get; set; }

    }
}
