using RestaurantFactory.Common.Factories;
using RestaurantFactory.Common.Products;
using RestaurantFactory.FastFood.Products;

namespace RestaurantFactory.FastFood;

/// <summary>
/// Concrete Factories implement creation methods of the abstract factory.
/// Each concrete factory corresponds to a specific variant of products and creates only those product variants.
/// </summary>
public class FastFoodRestaurantFactory : IRestaurantFactory
{
    public IAppertizer PrepareAppetizer() => new FastFoodAppetizer();

    public IMainCourse PrepareMainCourse() => new FastFoodMainCourse();

    public IDessert PrepareDessert() => new FastFoodDessert();
}
