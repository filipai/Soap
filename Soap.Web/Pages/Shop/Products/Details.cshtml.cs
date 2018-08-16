using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Soap.Web.Data;

namespace Soap.Web.Pages.Shop.Products
{
    public class DetailsModel : PageModel
    {
        public DetailsModel(SoapDbContext context)
        {
            this.Context = context;
        }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public int Quantity { get; set; }

        public decimal BasePrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public string Category { get; set; }

        public SoapDbContext Context { get; private set; }

        public IActionResult OnGet(int id)
        {
            var product = this.Context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            this.Name = product.Name;
            this.Brand = product.Brand;
            this.Description = product.Description;
            this.ImageURL = product.ImageURL;
            this.Quantity = product.Quantity;
            this.CurrentPrice = product.CurrentPrice;
            this.BasePrice = product.BasePrice;
            this.Category = product.Category.Name;

            return this.Page();
        }
    }
}