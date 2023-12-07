using ChainOfResponsibilityLibrary.LoggingExample;
using ChainOfResponsibilityLibrary.PokerExample;

namespace ChainOfResponsibilityLibrary
{
    public class Program
    {
        // Intent: Lets you pass requests along a chain of handlers. Upon receiving a
        // request, each handler decides either to process the request or to pass it to
        // the next handler in the chain.
        public static void Main(string[] args)
        {
            LoggingExecutor.Execute();
            PokerExecutor.Execute();

        }
    }
}