using System;
using ObserverLibrary.StockExample.Examples.Traditional.Publishers;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Subscribers;

public class MicrosoftSubscriber : Subscriber
{
    private const decimal StockTargetPrice = 230.0m;
    private readonly StockTicker stockTicker;

    public MicrosoftSubscriber(StockTicker stockTicker)
    {
        this.stockTicker = stockTicker;
        this.stockTicker.Subscribe(this);
    }
    public override void Update()
    {
        var price = stockTicker.LastChangedStock.Price;
        var symbol = stockTicker.LastChangedStock.Symbol;

        if (symbol == "MSFT" && price >= StockTargetPrice)
        {
            Console.WriteLine($"Microsoft's stock price has met or exceeded the target price of {StockTargetPrice:C}. The new price is: {price:C}");
        }
    }
}