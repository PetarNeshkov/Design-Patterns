using System;
using System.Collections.Generic;
using System.Linq;
using ObserverLibrary.NewspaperExample.Subscribers.Common;

namespace ObserverLibrary.NewspaperExample.Publishers.Common
{
    public class Newspaper
    {
        private readonly Dictionary<string, IUser> subscribers;
        private readonly string name;
        private decimal monthlyPrice;

        public Newspaper(string name, decimal monthlyPrice)
        {
            this.name = name;
            this.monthlyPrice = monthlyPrice;
            
            subscribers = new Dictionary<string, IUser>();
        }
        
        public decimal MonthlyPrice
        {
            get => monthlyPrice;
            set
            {
                if (monthlyPrice != value)
                {
                    monthlyPrice = value;
                    Console.WriteLine($"Monthly price for {name} newspaper is changed to {monthlyPrice:C}.");

                    Notify();
                }
            }
        }
        
        public void Subscribe(IUser user)
        {
            subscribers.Add(user.Username, user);
            Console.WriteLine($"{user.Name} is subscribed to {name} newspaper.");
        }
        
        public void Unsubscribe(IUser user)
        {
            subscribers.Remove(user.Username);
            Console.WriteLine($"{user.Name} is unsubscribed from {name} newspaper.");
        }
        
        private void Notify()
        {
            foreach (var user in subscribers.Values.ToList())
            {
                user.ReportSubscriptionPriceChange(this);
            }
        }
    }
}