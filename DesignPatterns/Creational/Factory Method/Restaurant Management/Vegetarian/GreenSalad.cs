using Restaurant_Management.Common;

namespace Restaurant_Management.Vegetarian;

/// <summary>
/// Concrete products are different implementations of the product interface <see cref="IMeal"/>.
/// </summary>
public class GreenSalad : IMeal
{
    public void ShowDescription()
    {
        Console.WriteLine("Green salad - tomatoes, cucumbers and green olives");
    }
}