using RestaurantFactory.Common.Products;

namespace RestaurantFactory.Vegetarian.Products;

public class VegetarianDessert : IDessert
{
    public void ShowDescription()
    {
        Console.WriteLine("Rice Pudding - with milk and vanilla extract");
    }

    public void ShowSugarAmount()
    {
        Console.WriteLine("Low sugar amount.");
    }
}
