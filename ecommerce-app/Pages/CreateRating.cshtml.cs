using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ecommerce_app.Pages
{
    public class CreateRatingModel : PageModel
    {
        [BindProperty]
        public Rating Rating { get; set; }

        public void OnGet()
        {
        }
    }
}
