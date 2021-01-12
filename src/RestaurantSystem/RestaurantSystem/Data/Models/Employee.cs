using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobPosition { get; set; }
        public int Salary { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<EmployerReport> Reports { get; set; } = new HashSet<EmployerReport>();
    }
}
