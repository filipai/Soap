using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Soap.Models;
using Soap.Web.Data;

namespace Soap.Web.Pages.Shop.Products
{
    public class Add : PageModel
    {
        public Add(SoapDbContext context)
        {
            this.Context = context;
        }

        public SoapDbContext Context { get; set; }

        [BindProperty]
        [Display(Name = "Name", Prompt = "Add name")]
        public string Name { get; set; }

        [BindProperty]
        [Display(Name = "Brand", Prompt = "Add brand")]
        public string Brand { get; set; }

        [BindProperty]
        [Display(Name = "Description", Prompt = "Add description")]
        public string Description { get; set; }

        [BindProperty]
        [Display(Name = "Ingredients", Prompt = "Add ingredients")]
        public string Ingredients { get; set; }

        [BindProperty]
        [Display(Name = "Image URL", Prompt = "Add image")]
        [DataType(DataType.Url)]
        public string ImageURL { get; set; }

        [BindProperty]
        [Display(Name = "Quantity", Prompt = "Add quantity")]
        public int Quantity { get; set; }

        [BindProperty]
        [Display(Name = "Base price", Prompt = "Add base price")]
        public decimal BasePrice { get; set; }

        [BindProperty]
        [Display(Name = "Current price", Prompt = "Add current price")]
        public decimal CurrentPrice { get; set; }

        [BindProperty]
        [Display(Name = "Category", Prompt = "Add category")]
        public string Category { get; set; }

        public void OnGet()
        {
            //List<Category> categoryList = new List<Category>();
            //categoryList = this.Context.Category.ToList();

            //return View(categoryList);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return this.Page();
            }

            var product = this.CreateProduct();


            return this.RedirectToPage("/Shop/Products/Details", new { id = product.Id });
        }

        private Product CreateProduct()
        {
            Category category = this.TakeOrCreateCAtegory();

            Product product = new Product()
            {
                Name = this.Name,
                Brand = this.Brand,
                Description = this.Description,
                ImageURL = this.ImageURL,
                Quantity = this.Quantity,
                BasePrice = this.BasePrice,
                CurrentPrice = this.CurrentPrice,
                Category = category
            };

            this.Context.Products.Add(product);
            this.Context.SaveChanges();
            return product;
        }

        private Category TakeOrCreateCAtegory()
        {
            Category category = this.Context.Categories.FirstOrDefault(c => c.Name == this.Category);

            if (category == null)
            {
                category = new Category() { Name = this.Category };

                this.Context.Categories.Add(category);
                this.Context.SaveChanges();
            }

            return category;
        }
    }
}