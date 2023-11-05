
using CustomSandwichBuilder.Builders;
using CustomSandwichBuilder.Builders.Director;
using CustomSandwichBuilder.Builders.Products;

// Intent: Lets you construct complex objects step by step. The pattern allows
// you to produce different types and representations of an object using the
// same construction code.

//<summary>
// The Client must associate one of the builder objects with the director.
// Usually, it’s done just once, via parameters of the director’s constructor.
// Then the director uses that builder object for all further construction.
// However, there’s an alternative approach for when the client passes the builder object
// to the production method of the director.
// In this case, you can use a different builder each time you produce something with the director.
// </summary>
var cheapSandwichBuilder = new CheapSandwichBuilder();
var premiumSandwichBuilder = new PremiumSandwichBuilder();

var director = new SandwichDirector(cheapSandwichBuilder);
MakeAndDisplaySandwich(director);


director.ChangeBuilder(premiumSandwichBuilder);
MakeAndDisplaySandwich(director);


void MakeAndDisplaySandwich(SandwichDirector director)
{
    director.MakeSandwich();

    var sandwich = director.GetSandwich();
    sandwich.Display();
}


