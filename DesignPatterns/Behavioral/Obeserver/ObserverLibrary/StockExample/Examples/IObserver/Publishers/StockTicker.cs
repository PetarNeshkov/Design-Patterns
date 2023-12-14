using System;
using System.Collections.Generic;
using ObserverLibrary.StockExample.Examples.IObserver.Subscribers;

namespace ObserverLibrary.StockExample.Examples.IObserver.Publishers;

public class StockTicker : IObservable<Stock>
{
    private readonly List<IObserver<Stock>> subscribers = new();
    private Stock lastChangedStock = Stock.Default();
    
    public void ProcessNewStockChange(Stock stock)
    {
        lastChangedStock = stock;
        Notify(lastChangedStock);
    }
    
    public IDisposable Subscribe(IObserver<Stock> subscriber)
    {
        if (!subscribers.Contains(subscriber))
        {
            subscribers.Add(subscriber);
        }

        return new DisposableSubscriber(subscribers, subscriber);
    }
    
    private void Notify(Stock stock)
    {
        var isReportWithBadData = string.IsNullOrWhiteSpace(stock.Symbol) || stock.Price < 0;

        foreach (var subscriber in subscribers)
        {
            if (isReportWithBadData)
            {
                subscriber.OnError(new ArgumentException("Bad stock data"));
                continue;
            }

            subscriber.OnNext(stock);
        }
    }
}