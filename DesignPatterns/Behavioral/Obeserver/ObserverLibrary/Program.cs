using ObserverLibrary.Motivating;
using ObserverLibrary.NewspaperExample;
using ObserverLibrary.StockExample.Examples.EventAndDelegate;
using ObserverLibrary.StockExample.Examples.IObserver;

namespace ObserverLibrary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NewspaperExecutor.Execute();
            EventAndDelegateExecutor.Execute();
            ObserverExecutor.Execute();
            MotivatingExecutor.Execute();
        }
    }
}