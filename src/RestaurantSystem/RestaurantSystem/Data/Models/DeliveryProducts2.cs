using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data.Models
{
    public class DeliveryProducts2
    {

        public int DeliveryId { get; set; }

        public Delivery Delivery { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}