using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.Models;
using ecommerce_app.Pages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ecommerce_app.Pages
{
    public class RatingsModel : PageModel
    {
        private readonly IRating _rating;
        public RatingsModel(IRating rating)
        {
            _rating = rating;

        }

        public IEnumerable<Rating> Ratings { get; set; } 

        public async void OnGet()
        {
            Ratings = await _rating.GetRatings();

            RedirectToPage("/Index", Ratings);
        }
    }
}
