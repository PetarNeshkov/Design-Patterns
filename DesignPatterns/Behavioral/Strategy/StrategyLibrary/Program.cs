using StrategyLibrary.ShippingExample;
using StrategyLibrary.SortingExample;

namespace StrategyLibrary
{
    // Intent: Lets you define a family of algorithms, put each of them into a
    // separate class, and make their objects interchangeable.
    public class Program
    {
        public static void Main(string[] args)
        {
            ShippingExecutor.Execute();
            SortingExecutor.Execute();
        }
    }
}