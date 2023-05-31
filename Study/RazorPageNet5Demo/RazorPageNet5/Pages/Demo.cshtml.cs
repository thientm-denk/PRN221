using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageNet5.Pages
{
    public class DemoModel : PageModel
    {
        public void OnGet()
        {
            ViewData["DemoMsg"] = "Hello";
        }
    }
}
