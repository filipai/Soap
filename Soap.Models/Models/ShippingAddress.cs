using System;
using System.Collections.Generic;
using System.Text;

namespace Soap.Models
{
    public class ShippingAddress
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string ContactPersonName { get; set; }

        public string ContactPersonPhone { get; set; }
    }
}
