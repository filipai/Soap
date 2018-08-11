using System.Collections;
using System.Collections.Generic;

namespace Soap.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public int Amount { get; set; }

        public decimal BasePrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}