using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Soap.Web.Data;
using Soap.Web.Models;

namespace Soap.Web.Pages
{
    public class SearchModel : AppPageModel
    {
        public SearchModel(SoapDbContext context) : base(context)
        {
            this.SearchResults = new List<SearchProductViewModel>();
        }

        public List<SearchProductViewModel> SearchResults { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(this.SearchTerm))
            {
                return;
            }


            var foundProducts = this.Context.Products
                    .Where(p => p.Name.Contains(this.SearchTerm))
                    .OrderBy(p => p.Name)
                    .Select(p => new SearchProductViewModel()
                    {
                        ProductId = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        CurrentPrice = p.CurrentPrice,
                        ImageUrl = p.ImageURL
                    }).ToList();

            this.SearchResults.AddRange(foundProducts);
        }
    }
}