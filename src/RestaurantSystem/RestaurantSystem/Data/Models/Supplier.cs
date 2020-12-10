using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class Supplier
    {

        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public ICollection<Delivery> Deliveries { get; set; }

    }
}
