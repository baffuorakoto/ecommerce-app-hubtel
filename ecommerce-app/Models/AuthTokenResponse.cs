using System;
namespace ecommerce_app.Models
{
    public class AuthTokenResponse
    {
        public string Message { get; set; }
        public string Code { get; set; }
        public Data Data { get; set; }
    }
}
