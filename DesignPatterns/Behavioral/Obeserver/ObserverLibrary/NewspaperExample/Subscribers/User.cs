using ObserverLibrary.NewspaperExample.Publishers.Common;
using ObserverLibrary.NewspaperExample.Subscribers.Common;

namespace ObserverLibrary.NewspaperExample.Subscribers;

public class User : IUser
{
    private readonly decimal availableMonthlySubscriptionAmount;

    public User(string name, string username, decimal availableMonthlySubscriptionAmount)
    {
        Name = name;
        Username = username;
        this.availableMonthlySubscriptionAmount = availableMonthlySubscriptionAmount;
    }

    public string Username { get; set; }
    
    public string Name { get; set; }
    
    public void ReportSubscriptionPriceChange(Newspaper newspaper)
    {
        if (newspaper.MonthlyPrice > availableMonthlySubscriptionAmount)
        {
            newspaper.Unsubscribe(this);
        }
    }
}