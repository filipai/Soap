using Soap.Models;
using System;

namespace Soap.Web.Models
{
    public class SearchProductViewModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal CurrentPrice { get; set; }

        public static Func<Product, ProductConciseViewModel> FromProduct
        {
            get
            {
                return product => new ProductConciseViewModel
                {
                    Name = product.Name,
                    Description = product.Description,
                    CurrentPrice = product.CurrentPrice,
                    ImageUrl = product.ImageURL,
                    ProductId = product.Id,
                };
            }
        }
    }
}
