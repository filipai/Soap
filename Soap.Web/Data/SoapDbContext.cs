using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Soap.Models;

namespace Soap.Web.Data
{
    public class SoapDbContext : IdentityDbContext
    {
        public SoapDbContext(DbContextOptions<SoapDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
    }
}
