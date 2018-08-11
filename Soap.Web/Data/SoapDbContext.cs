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

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ShippingAddress> ShippingAddress { get; set; }
    }
}
