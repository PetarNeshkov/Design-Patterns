using System;
using System.Collections.Generic;

namespace ObserverLibrary.StockExample.Examples.IObserver.Subscribers;

public class DisposableSubscriber : IDisposable
{
    private readonly List<IObserver<Stock>> subscribers;
    private readonly IObserver<Stock> currentSubscriber;
    
    public DisposableSubscriber(List<IObserver<Stock>> subscribers, IObserver<Stock> currentSubscriber)
    {
        this.subscribers = subscribers;
        this.currentSubscriber = currentSubscriber;
    }
    
    public void Dispose()
    {
        if (subscribers.Contains(currentSubscriber))
        {
            subscribers.Remove(currentSubscriber);
        }
    }
}