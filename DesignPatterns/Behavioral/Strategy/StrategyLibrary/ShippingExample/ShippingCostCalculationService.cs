using StrategyLibrary.ShippingExample.ShippingProviders.Common;

namespace StrategyLibrary.ShippingExample
{
    public class ShippingCostCalculationService
    {
        private readonly IShippingProvider shippingProvider;

        public ShippingCostCalculationService(IShippingProvider shippingProvider)
        {
            this.shippingProvider = shippingProvider;
        }

        public decimal Calculate(Order order)
            => shippingProvider.CalculateCost(order);
    }
}