using System.Collections.Generic;

namespace Soap.Models
{
    public class Category
    {
        public Category()
        {
            this.Proucts = new List<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ProductId { get; set; }

        public ICollection<Product> Proucts { get; set; }
    }
}
