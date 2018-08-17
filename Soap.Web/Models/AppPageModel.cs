using Microsoft.AspNetCore.Mvc.RazorPages;
using Soap.Web.Data;

namespace Soap.Web.Models
{
    public class AppPageModel : PageModel
    {
        public AppPageModel(SoapDbContext context)
        {
            this.Context = context;
        }

        protected SoapDbContext Context { get; set; }
    }
}
