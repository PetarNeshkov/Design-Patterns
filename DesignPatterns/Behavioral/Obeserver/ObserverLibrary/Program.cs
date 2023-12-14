using ObserverLibrary.NewspaperExample;
using ObserverLibrary.StockExample.Examples.EventAndDelegate;
using ObserverLibrary.StockExample.Examples.IObserver;
using ObserverLibrary.StockExample.Examples.Motivating;
using ObserverLibrary.StockExample.Examples.Traditional;

namespace ObserverLibrary
{
    // Intent: Lets you define a subscription mechanism to notify multiple objects
    // about any events that happen to the object they're observing.
    
    // Note that there's a lot of different terms with similar meaning associated
    // with this pattern. Just remember that the Subject is also called the
    // Publisher and the Observer is often called the Subscriber and vice versa.
    // Also the verbs "observe", "listen" or "track" usually mean the same thing.
    public class Program
    {
        public static void Main(string[] args)
        {
            NewspaperExecutor.Execute();
            EventAndDelegateExecutor.Execute();
            ObserverExecutor.Execute();
            MotivatingExecutor.Execute();
            TraditionalExecutor.Execute();
        }
    }
}