using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Soap.Web.Data;
using Soap.Web.Models;

namespace Soap.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(SoapDbContext context)
        {
            this.Context = context;
        }

        public SoapDbContext Context { get; set; }

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
