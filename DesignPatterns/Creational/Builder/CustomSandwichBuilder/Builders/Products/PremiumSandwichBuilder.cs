using CustomSandwichBuilder.Builders.Common;
using CustomSandwitchBuilder.Builders.Products;
using CustomSandwitchBuilder.Builders.Products.Enums;

namespace CustomSandwichBuilder.Builders.Products;

public class PremiumSandwichBuilder : SandwichBuilder
{
    public override void CreateNewSandwich()
        => Sandwich = new Sandwich("Premium sandwich");

    public override void AddCondiments()
    {
        Sandwich.HasMustard = true;
        Sandwich.HasMayonnaise = true;
        Sandwich.HasKetchup = true;
    }

    public override void ApplyMeatAndCheese()
    {
        Sandwich.MeatType = MeatType.Beef;
        Sandwich.CheeseType = CheeseType.Pule;
    }

    public override void ApplyVegetables() 
        => Sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };

    public override void PrepareBread()
        => Sandwich.BreadType = BreadType.WholeGrain;
}