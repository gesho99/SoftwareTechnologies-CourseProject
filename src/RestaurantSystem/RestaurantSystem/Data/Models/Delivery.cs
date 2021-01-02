using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class Delivery
    {

        public int Id { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        [Required]
        public double DeliveryPrice { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public int DeliveryQuantity { get; set; }

        public bool Approved { get; set; }

        public ICollection<DeliveryProducts2> DeliveryProducts2 { get; set; } = new HashSet<DeliveryProducts2>();

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}
