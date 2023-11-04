using Restaurant_Management.Common;

namespace Restaurant_Management.FastFood;

/// <summary>
/// Concrete creators override the base factory method so it returns a different type of product.
/// </summary>
public class FastFoodRestaurant : Restaurant
{
    protected override IMeal PrepareMainCourse()
    {
       return new Hamburger();
    }
}