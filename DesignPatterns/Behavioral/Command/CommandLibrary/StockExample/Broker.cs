using System.Collections.Generic;
using CommandLibrary.StockExample.Common;

namespace CommandLibrary.StockExample;

public class Broker
{
    private readonly List<IOrderCommand> orders;

    public Broker()
    {
        orders = new List<IOrderCommand>();
    }
    
    public void TakeOrder(IOrderCommand order) => orders.Add(order);

    public void ProcessOrders()
    {
        foreach (var order in orders)
        {
            order.Execute();
        }

        orders.Clear();
    }
}