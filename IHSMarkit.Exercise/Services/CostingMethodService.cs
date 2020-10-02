using IHSMarkit.Exercise.Models;
using System.Collections.Generic;
using System.Linq;

namespace IHSMarkit.Exercise.Services
{
    public static class CostingMethodService
    {
        public static CostingMethodResult FirstInFirstOut(IEnumerable<Share> shares, int quantity)
        {
            return GetCostPrice(shares.OrderBy(s => s.PurchaseDate), quantity);
        }

        public static CostingMethodResult LastInFirstOut(IEnumerable<Share> shares, int quantity)
        {
            return GetCostPrice(shares.OrderByDescending(s => s.PurchaseDate), quantity);
        }

        public static CostingMethodResult HighestCost(IEnumerable<Share> shares, int quantity)
        {
            return GetCostPrice(shares.OrderByDescending(s => s.Price), quantity);
        }

        public static CostingMethodResult LowestCost(IEnumerable<Share> shares, int quantity)
        {
            return GetCostPrice(shares.OrderBy(s => s.Price), quantity);
        }

        public static CostingMethodResult WeightedAverage(IEnumerable<Share> shares, int quantity, decimal price)
        {
            var totalSharesPrice = shares.Sum(s => s.Price * s.Quantity);
            var totalSharesQuantity = shares.Sum(s => s.Quantity);
            var costPrice = totalSharesPrice / totalSharesQuantity;
            var remainingCostPrice = (totalSharesPrice - (price * quantity)) / (totalSharesQuantity - quantity);

            return new CostingMethodResult
            {
                CostPrice = costPrice,
                RemainingCostPrice = remainingCostPrice
            };
        }

        private static CostingMethodResult GetCostPrice(IEnumerable<Share> shares, int quantity)
        {
            var cumulativeCost = 0m;
            var cumulativeRemainingCost = 0m;
            var remainingSharesToSell = quantity;

            foreach (var share in shares)
            {
                var sellAllShares = remainingSharesToSell > share.Quantity;
                var soldShares = sellAllShares ? share.Quantity : remainingSharesToSell;

                if (remainingSharesToSell > 0)
                {
                    cumulativeCost += share.Price * soldShares;
                    remainingSharesToSell -= soldShares;
                }

                if (remainingSharesToSell <= 0 && !sellAllShares)
                {
                    cumulativeRemainingCost += share.Price * (share.Quantity - soldShares);
                }
            }

            return new CostingMethodResult
            {
                CostPrice = cumulativeCost / quantity,
                RemainingCostPrice = cumulativeRemainingCost / (shares.Sum(s => s.Quantity) - quantity)
            };
        }
    }
}
