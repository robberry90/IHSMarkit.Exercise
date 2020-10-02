using System;

namespace IHSMarkit.Exercise.Models
{
    public class Share
    {
        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
