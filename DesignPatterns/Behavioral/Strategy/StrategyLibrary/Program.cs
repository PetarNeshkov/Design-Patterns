using StrategyLibrary.ShippingExample;
using StrategyLibrary.SortingExample;

namespace StrategyLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShippingExecutor.Execute();
            SortingExecutor.Execute();
        }
    }
}