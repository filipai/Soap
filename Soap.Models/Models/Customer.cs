using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Soap.Models
{
    public class Customer : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int OrderId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
