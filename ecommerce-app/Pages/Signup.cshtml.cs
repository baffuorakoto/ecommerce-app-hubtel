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
    public class SignupModel : PageModel
    {
        private readonly IAuth _auth;
        public SignupModel(IAuth auth)
        {
            _auth = auth;
        }

        [BindProperty]
        public string PhoneNumber { get; set; }

        public void OnGet()
        {

        }

        public  async Task<IActionResult> OnPost()
        {
            var authTokenResponse = await _auth.GetToken(PhoneNumber);
            

             return RedirectToPage("/Privacy", authTokenResponse);
        }
    }
}
