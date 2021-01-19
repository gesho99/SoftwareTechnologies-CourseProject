using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class Table
    {

        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

    }
}
