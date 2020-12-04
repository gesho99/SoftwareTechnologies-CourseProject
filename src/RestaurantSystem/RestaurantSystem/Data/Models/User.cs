using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class User
    {

        public int Id { get; set; }

        public int EmployerId { get; set; }

        [ForeignKey("EmployerId")]
        public Employer Employer { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        [Required]
        [MaxLength(15)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }


    }
}
