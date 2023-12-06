using CustomSandwichBuilder.Builders.Products;

namespace CustomSandwichBuilder.Builders.Common;

/// <summary>
/// The Builder interface or abstract class declares product 
/// construction steps that are common to all types of builders.
/// </summary>
public abstract class SandwichBuilder
{
    protected Sandwich Sandwich = new();

    protected SandwichBuilder()
    {
        Reset();
    }

    /// <summary>
    /// Get prepared sandwich.
    /// If concrete builders don't follow the same interface 
    /// this method must be moved to the concrete builder's class.
    /// </summary>
    /// <returns>Sandwich.</returns>
    public Sandwich GetSandwich()
    {
        Sandwich result = Sandwich;

        Reset();

        return result;
    }
    
    public abstract void CreateNewSandwich();

    public abstract void PrepareBread();

    public abstract void ApplyMeatAndCheese();

    public abstract void ApplyVegetables();

    public abstract void AddCondiments();

    private void Reset()
    {
        Sandwich = new Sandwich();
    }
}