using RestaurantFactory.Common.Factories;
using RestaurantFactory.Common.Products;
using RestaurantFactory.Vegetarian.Products;

IRestaurantFactory factory = new VegetarianRestaurantFactory();

IAppertizer appetizer = factory.PrepareAppetizer();
appetizer.ShowDescription();

IMainCourse mainCourse = factory.PrepareMainCourse();
mainCourse.ShowDescription();

IDessert dessert = factory.PrepareDessert();
dessert.ShowDescription();
dessert.ShowSugarAmount();