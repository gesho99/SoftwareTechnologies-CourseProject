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

        public int EmpId { get; set; }

        [ForeignKey("EmpId")]
        public Employee Employeе { get; set; }

        public int DayAccountingId { get; set; }

        [ForeignKey("DayAccountingId")]
        public DayAccountings DayAccounting { get; set; }

        [Required]
        public double Bill { get; set; }

        [Required]
        public DateTime ReportDate { get; set; }

        public ICollection<Dish> Dishes { get; set; } = new HashSet<Dish>();

    }
}
