using MealFactory.Meals.Common;

namespace MealFactory.Meals;

public class Hamburger : IMeal
{
    public void ShowAmountOfCalories() =>
        Console.WriteLine("Calories: 450 kcal");

    public void ShowDescription() =>
        Console.WriteLine("Hamburger: beef meat, Worcestershire sauce and cheese.");
}
