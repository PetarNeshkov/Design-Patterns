using CustomSandwichBuilder.Builders.Common;
using CustomSandwitchBuilder.Builders.Products;

namespace CustomSandwichBuilder.Builders.Director;

/// <summary>
/// The Director class defines the order in which to call construction steps,
/// so you can create and reuse specific configurations of products.
/// </summary>
public class SandwichDirector
{
    private SandwichBuilder builder;

    public SandwichDirector(SandwichBuilder builder)
    {
        this.builder = builder;
    }
    
    public void ChangeBuilder(SandwichBuilder newBuilder) 
        => builder = newBuilder;

    public void MakeSandwich()
    {
        builder.CreateNewSandwich();
        builder.PrepareBread();
        builder.ApplyMeatAndCheese();
        builder.ApplyVegetables();
        builder.AddCondiments();
    }
    
    public Sandwich GetSandwich() 
        => builder.GetSandwich();
}