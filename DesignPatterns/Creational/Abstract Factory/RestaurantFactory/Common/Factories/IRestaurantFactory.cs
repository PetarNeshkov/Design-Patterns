using RestaurantFactory.Common.Products;

namespace RestaurantFactory.Common.Factories;

/// <summary>
/// The Abstract Factory interface declares a set of methods for creating each of the abstract products.
/// </summary>

/// Abstract Products declare interfaces for a set of distinct
/// but related products which make up a product family.
public interface IRestaurantFactory
{
    IAppertizer PrepareAppetizer();

    IMainCourse PrepareMainCourse();

    IDessert PrepareDessert();
}