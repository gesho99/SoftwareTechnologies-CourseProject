using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class DayAccountings
    {

        public int Id { get; set; }

        public double DayExpense { get; set; }

        public double DayIncome { get; set; }

        public double DayProfit { get; set; }

        public DateTime Date { get; set; }

        public ICollection<EmployerReport> EmployerReports { get; set; }
         
    }
}
