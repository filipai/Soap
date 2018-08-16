using System.Collections;
using System.Collections.Generic;

namespace Soap.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public string ImageURL { get; set; }

        public decimal BasePrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public int? OrderId { get; set; }

        public Order Order { get; set; }

        public Category Category { get; set; }
    }
}