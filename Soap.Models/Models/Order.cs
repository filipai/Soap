using System;
using System.Collections.Generic;

namespace Soap.Models
{
    public class Order
    {
        public Order()
        {
            this.Products = new List<Product>();
        }

        public int OrderId { get; set; }

        public string Name { get; set; }

        public DateTime OrderDateTime { get; set; }

        public double TotalValue { get; set; }

        public int ProductId { get; set; }

        public ICollection<Product> Products { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int? SippingAddressId { get; set; }

        public ShippingAddress ShippingAddress { get; set; }
    }
}
