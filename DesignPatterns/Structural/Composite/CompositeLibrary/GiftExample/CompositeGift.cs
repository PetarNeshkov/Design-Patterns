using CompositeLibrary.GiftExample.Common;

namespace CompositeLibrary.GiftExample;

public class CompositeGift : Gift, IGiftOperations
{
    /// <summary>
    /// This collection can store simple as well as composite gifts.
    /// </summary>
    private readonly List<Gift> gifts;
    
    public CompositeGift(string description) 
        : base(description, 0)
    {
        gifts = new List<Gift>();
    }

    public override decimal CalculatePrice()
    {
        Console.WriteLine($"'{description}' contains the following products with prices:");
        price = gifts.Sum(gift => gift.CalculatePrice());

        return price;
    }

    public void Add(Gift gift)
    {
       gifts.Add(gift);
    }

    public void Remove(Gift gift)
    {
        gifts.Remove(gift);
    }
}