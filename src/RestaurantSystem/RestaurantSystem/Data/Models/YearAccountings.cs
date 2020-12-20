using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class YearAccountings
    {
        public int Id { get; set; }

        public double YearExpense { get; set; }

        public double YearIncome { get; set; }

        public double YearProfit { get; set; }

        public DateTime Date { get; set; }

        public ICollection<MonthAccountings> MonthAccountings { get; set; } = new HashSet<MonthAccountings>();

    }
}
