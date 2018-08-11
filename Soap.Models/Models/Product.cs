using System.Collections;
using System.Collections.Generic;

namespace Soap.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public int ProductPageId { get; set; }

        public int Amount { get; set; }

        public double CurrentPrice { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}