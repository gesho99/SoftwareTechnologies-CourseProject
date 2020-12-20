using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class MonthAccountings
    {
        public int Id { get; set; }

        public int YearAccountingId { get; set; }

        [ForeignKey("YearAccountingsId")]
        public YearAccountings YearAccountings { get; set; }

        public double MonthExpense { get; set; }

        public double MonthIncome { get; set; }

        public double MonthProfit { get; set; }

        public DateTime Date { get; set; }

        public ICollection<DayAccountings> DayAccountings { get; set; } = new HashSet<DayAccountings>();

    }
}
