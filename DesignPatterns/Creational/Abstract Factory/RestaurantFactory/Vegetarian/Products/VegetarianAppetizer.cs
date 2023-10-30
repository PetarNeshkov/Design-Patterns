using RestaurantFactory.Common.Products;

namespace RestaurantFactory.Vegetarian.Products;

public class VegetarianAppetizer : IAppertizer
{
    public void ShowDescription()
    {
        Console.WriteLine("Broth - with pumpkin.");
    }

    public bool IsBroth() => true;
}
