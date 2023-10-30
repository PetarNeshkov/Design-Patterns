using MealFactory.Meals.Common;

namespace MealFactory.Meals;

public class GreenSalad : IMeal
{
    public void ShowAmountOfCalories() =>
        Console.WriteLine("Calories: 250 kcal");

    public void ShowDescription() =>
        Console.WriteLine("Green salad: lettuce, cucumber and green olives");
}
