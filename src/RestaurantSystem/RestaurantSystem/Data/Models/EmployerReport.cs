using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class EmployerReport
    {

        public int Id { get; set; }

        public int EmployerId { get; set; }

        public Employer Employer { get; set; }

        [Required]
        public double Bill { get; set; }

        [Required]
        public DateTime ReportDate { get; set; }

        public ICollection<Dish> Dishes { get; set; } = new HashSet<Dish>();

    }
}
