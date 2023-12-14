using ObserverLibrary.NewspaperExample;
using ObserverLibrary.StockExample.Examples.EventAndDelegate;

namespace ObserverLibrary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NewspaperExecutor.Execute();
            EventAndDelegateExecutor.Execute();
        }
    }
}