using System;

namespace CommandLibrary.StockExample;

public class Stock
{
    private readonly string name;
    private readonly int quantity;

    public Stock(string name, int quantity)
    {
        this.name = name;
        this.quantity = quantity;
    }
    
    public void Buy() => Console.WriteLine($"Stock [ Name: {name}, Quantity: {quantity} ] is bought.");

    public void Sell() => Console.WriteLine($"Stock [ Name: {name}, Quantity: {quantity} ] is sold.");
}