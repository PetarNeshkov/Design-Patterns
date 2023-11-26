using CompositeLibrary.GiftExample.Common;

namespace CompositeLibrary.GiftExample;

public class SimpleGift : Gift
{
    public SimpleGift(string description, decimal price) 
        : base(description, price)
    {
    }

    public override decimal CalculatePrice()
    {
        Console.WriteLine($"'{description}' with the price of {price:C}");
        
        return price;
    }
}