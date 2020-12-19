using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class DayAccountings
    {

        public int Id { get; set; }

        public int MonthAccountingId { get; set; }

        [ForeignKey("MonthAccountingId")]
        public MonthAccountings MonthAccountings { get; set; }

        public double DayExpense { get; set; }

        public double DayIncome { get; set; }

        public double DayProfit { get; set; }

        public DateTime Date { get; set; }

        public ICollection<EmployerReport> EmployerReports { get; set; } = new HashSet<EmployerReport>();
         
    }
}
