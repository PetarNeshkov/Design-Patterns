using RestaurantFactory.Common.Factories;
using RestaurantFactory.Common.Products;

namespace RestaurantFactory.Vegetarian.Products;

/// <summary>
/// Concrete Factories implement creation methods of the abstract factory.
/// Each concrete factory corresponds to a specific variant of products and creates only those product variants.
/// </summary>
public class VegetarianRestaurantFactory : IRestaurantFactory
{
    public IAppertizer PrepareAppetizer() => new VegetarianAppetizer();

    public IMainCourse PrepareMainCourse() => new VegetarianMainCourse();

    public IDessert PrepareDessert() => new VegetarianDessert();
}
