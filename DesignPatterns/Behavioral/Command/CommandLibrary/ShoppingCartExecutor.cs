using System;
using CommandLibrary.ShoppingCartExample;
using CommandLibrary.ShoppingCartExample.Commands;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary;

public static class ShoppingCartExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Shopping cart example");

        var productRepository = new ProductRepository();
        var shoppingCartRepository = new ShoppingCartRepository();

        const string productId = "XI-NOTE10";
        var product = productRepository.GetById(productId);
        if (product == null)
        {
            Console.WriteLine($"The product with the ID {productId} can't be found.");
            
            return;
        }

        var addToCartCommand = new AddToCartCommand(
            product,
            productRepository,
            shoppingCartRepository);

        var increaseQuantityCommand = new ChangeCartQuantityCommand(
            product,
            ChangeCartQuantityOperation.Increase,
            productRepository,
            shoppingCartRepository);

        var manager = new CommandManager();
        manager.Invoke(addToCartCommand);
        manager.Invoke(increaseQuantityCommand);
        manager.Invoke(increaseQuantityCommand);
        manager.Invoke(increaseQuantityCommand);
        manager.Invoke(increaseQuantityCommand);

        PrintCart(shoppingCartRepository);
        manager.Undo();
        PrintCart(shoppingCartRepository);
    }
    
    private static void PrintCart(IShoppingCartRepository shoppingCartRepository)
    {
        var totalPrice = 0m;

        foreach (var lineItem in shoppingCartRepository.GetAll())
        {
            var price = lineItem.Product.Price * lineItem.Quantity;

            Console.WriteLine(
                $"\nProduct [ " +
                $"Name: {lineItem.Product.Name}, " +
                $"Price: {lineItem.Product.Price:C}, " +
                $"Quantity: {lineItem.Quantity} ] " +
                $"-> Price: {price:C}");

            totalPrice += price;
        }

        Console.WriteLine($"Total price: {totalPrice:C}");
    }
}