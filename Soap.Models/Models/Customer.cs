using Microsoft.AspNetCore.Identity;

namespace Soap.Models
{
    public class Customer : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
