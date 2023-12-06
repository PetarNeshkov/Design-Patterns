using CustomSandwichBuilder.Builders.Common;
using CustomSandwichBuilder.Builders.Products;
using CustomSandwichBuilder.Builders.Products.Enums;

namespace CustomSandwichBuilder.Builders;

/// <summary>
/// Concrete Builders provide different implementations of the construction steps.
/// Note that, concrete builders may produce products that don't follow the common interface.
/// </summary>
public class CheapSandwichBuilder : SandwichBuilder
{
    public override void CreateNewSandwich()
    {
        Sandwich = new Sandwich("Cheap sandwich");
    }

    public override void PrepareBread()
    {
        Sandwich.BreadType = BreadType.White;
    }

    public override void ApplyMeatAndCheese()
    {
        Sandwich.MeatType = MeatType.Salami;
        Sandwich.CheeseType = CheeseType.Cheddar;
    }

    public override void ApplyVegetables()
    {
        Sandwich.Vegetables = new List<string> { "Tomato" };
    }

    public override void AddCondiments()
    {
        Sandwich.HasMayonnaise = true;
    }
}