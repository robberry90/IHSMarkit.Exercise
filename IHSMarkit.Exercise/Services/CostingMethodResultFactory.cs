using IHSMarkit.Exercise.Enums;
using IHSMarkit.Exercise.Models;
using System;
using System.Collections.Generic;

namespace IHSMarkit.Exercise.Services
{
    public static class CostingMethodResultFactory
    {
        public static CostingMethodResult GetCostingMethodResult(IEnumerable<Share> shares, int quantity, decimal price, CostingMethod costingMethod)
        {
            switch (costingMethod)
            {
                case CostingMethod.FirstInFirstOut:
                    return CostingMethodService.FirstInFirstOut(shares, quantity);
                case CostingMethod.LastInFirstOut:
                    return CostingMethodService.LastInFirstOut(shares, quantity);
                case CostingMethod.HighestCost:
                    return CostingMethodService.HighestCost(shares, quantity);
                case CostingMethod.LowestCost:
                    return CostingMethodService.LowestCost(shares, quantity);
                case CostingMethod.WeightedAverage:
                    return CostingMethodService.WeightedAverage(shares, quantity, price);
                default:
                    throw new Exception("Costing Method was not provided.");
            }
        }
    }
}
