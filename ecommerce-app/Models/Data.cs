using System;
using System.Collections.Generic;

namespace ecommerce_app.Models
{
    public class Data
    {
       
        public string Token { get; set; }
        public IEnumerable<Rating> Results { get; set; }
    }
}
