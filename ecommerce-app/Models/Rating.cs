using System;
namespace ecommerce_app.Models
{
    public class Rating
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string Comment { get; set; }
        public int Stars { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

       


    }
}
