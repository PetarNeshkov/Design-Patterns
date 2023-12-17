using StrategyLibrary.ShippingExample.ShippingProviders.Common;

namespace StrategyLibrary.ShippingExample
{
    // EN: The Context maintains a reference to one of the Strategy objects.
    // The Context does not know the concrete class of a strategy. It should
    // work with all strategies via the Strategy interface.
    
    // EN: Usually, the Context accepts a strategy through the constructor,
    // but also provides a setter to change it at runtime.
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