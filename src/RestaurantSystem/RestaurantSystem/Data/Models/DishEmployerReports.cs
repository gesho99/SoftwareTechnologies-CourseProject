using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class DishEmployerReports
    {
        public virtual EmployerReport EmployerReport { get; set; }

        public int EmployerReportId { get; set; }

        public virtual Dish Dish { get; set; }

        public int DishId { get; set; }

    }
}
