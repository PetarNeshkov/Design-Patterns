using System.Reflection;
using MealFactory.Meals;
using MealFactory.Meals.Common;

namespace MealFactory.Factories;

/// <summary>
/// A simple meal factory that creates various types of meals based on a key for Type lookup.
/// It doesn't implement any interface, it's just a simple factory.
/// </summary>
public class MealFactory
{
    private readonly Dictionary<string, Type> meals = new();

    public MealFactory()
    {
        LoadAvailableMealTypes();
    }

    public IMeal CreateMeal(string mealName)
    {
        var type = GetTypeForCreation(mealName);
        if (type == null)
        {
            return new NullMeal();
        }

        return (Activator.CreateInstance(type) as IMeal)!;
    }

    private Type? GetTypeForCreation(string mealName)
        => meals.TryGetValue(mealName, out var type) ? type : null;
    
    private void LoadAvailableMealTypes()
    {
        Type[] assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

        foreach (Type type in assemblyTypes)
        {
            if (type.GetInterface(typeof(IMeal).ToString()) != null)
            {
                meals.Add(type.Name, type);
            }
        }
    }
}
