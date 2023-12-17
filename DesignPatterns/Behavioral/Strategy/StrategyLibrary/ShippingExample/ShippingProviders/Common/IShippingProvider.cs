namespace StrategyLibrary.ShippingExample.ShippingProviders.Common
{
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface IShippingProvider
    {
        decimal CalculateCost(Order order);
    }
}