using System;
using ObserverLibrary.StockExample.Examples.Traditional.Publishers;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Subscribers;

public class GoogleSubscriber : Subscriber
{
    private readonly StockTicker stockTicker;

    public GoogleSubscriber(StockTicker stockTicker)
    {
        this.stockTicker = stockTicker;
        this.stockTicker.Subscribe(this);
    }

    public override void Update()
    {
        var price = stockTicker.LastChangedStock.Price;
        var symbol = stockTicker.LastChangedStock.Symbol;

        if (symbol == "GOOG")
        {
            Console.WriteLine($"Google's stock price has changed. The new price is: {price:C}");
        }
    }
}