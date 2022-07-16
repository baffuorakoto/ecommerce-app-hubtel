using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ecommerce_app.Models;

namespace ecommerce_app.Pages.Services
{
    public interface IRating
    {
        public Task<IEnumerable<Rating>> GetRatings();
        public void CreateRating();
       
    }
}
