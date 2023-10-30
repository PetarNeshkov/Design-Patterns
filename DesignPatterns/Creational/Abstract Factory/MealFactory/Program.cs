using MealFactory.Meals;
using MealFactory.Meals.Common;

var response = string.Empty;

while (response is not "1" and not "2")
{
    Console.WriteLine("Please choose the desired meal name (enter the number): ");
    Console.WriteLine("1. Green salad");
    Console.WriteLine("2. Hamburger");
    response = Console.ReadLine()!;
}

var mealName = response == "1" ? nameof(GreenSalad) : nameof(Hamburger);
var factory = new MealFactory.Factories.MealFactory();

IMeal meal = factory.CreateMeal(mealName);
meal.ShowDescription();
meal.ShowAmountOfCalories();