using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.Models;
using ecommerce_app.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ecommerce_app.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRating _rating;
        public IndexModel(IRating rating)
        {
            _rating = rating;
        }



        public IEnumerable<Rating> Ratings { get; set; }

        public async void OnGet()
        {
            Ratings = await _rating.GetRatings();
        }
    }
}
