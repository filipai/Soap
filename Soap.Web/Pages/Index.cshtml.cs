using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Soap.Web.Data;
using Soap.Web.Models;

namespace Soap.Web.Pages
{
    public class IndexModel : AppPageModel
    {
        public IndexModel(SoapDbContext context): base(context)
        {          
        }

        public IEnumerable<ProductConciseViewModel> Products { get; set; }

        public void OnGet()
        {
            this.Products = this.Context.Products
                .Include(p => p.Category)
                .OrderByDescending(p => p.Id)
                .Select(ProductConciseViewModel.FromProduct)
                .ToList();
        }
    }
}
