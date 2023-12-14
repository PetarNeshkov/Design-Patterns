using System.Collections.Generic;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Publishers.Common;

public abstract class Publisher
{
    private readonly List<Subscriber> subscribers = new();

    public void Subscribe(Subscriber subscriber) 
        => subscribers.Add(subscriber);

    public void Unsubscribe(Subscriber subscriber)
        => subscribers.Remove(subscriber);

    protected void NotifySubscribers()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update();
        }
    }
}