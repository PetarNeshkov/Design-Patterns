// Intent: Provides an interface for creating objects in a superclass, but
// allows subclasses to alter the type of objects that will be created.

using Restaurant_Management.FastFood;
using Restaurant_Management.Vegetarian;

var fastFoodRestaurant = new FastFoodRestaurant();
fastFoodRestaurant.OrderDailySpecial();

var vegetarianRestaurant = new VegetarianRestaurant();
vegetarianRestaurant.OrderDailySpecial();
