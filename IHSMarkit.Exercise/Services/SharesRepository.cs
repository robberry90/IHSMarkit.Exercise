using IHSMarkit.Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IHSMarkit.Exercise.Services
{
    public static class SharesRepository
    {
        private static List<Share> Shares = new List<Share>();

        public static List<Share> GetShares()
        {
            return Shares.Select(s => s).ToList();
        }

        public static void AddShares(DateTime PurchaseDate, int Quantity, decimal Price)
        {
            Shares.Add(new Share
            {
                PurchaseDate = PurchaseDate,
                Quantity = Quantity,
                Price = Price
            });
        }
    }
}
