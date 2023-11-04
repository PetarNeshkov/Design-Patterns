using Restaurant_Management.Common;

namespace Restaurant_Management.FastFood;

/// <summary>
/// Concrete products are different implementations of the product interface <see cref="IMeal"/>.
/// </summary>
public class Hamburger : IMeal
{
    public void ShowDescription()
    {
        Console.WriteLine("Hamburger - with beef meat, Worcestershire sauce and cheese.");
    }
}