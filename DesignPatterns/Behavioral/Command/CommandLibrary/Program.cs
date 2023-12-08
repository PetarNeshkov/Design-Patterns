using CommandLibrary.EmailExample;
using CommandLibrary.ShoppingCartExample;
using CommandLibrary.StockExample;

namespace CommandLibrary
{
    public class Program
    {
        // Intent: Turns a request into a stand-alone object that contains all
        // information about the request. This transformation lets you parameterize
        // methods with different requests, delay or queue a request's execution, and
        // support undoable operations.
        public static void Main(string[] args)
        {
            EmailExecutor.Execute();
            ShoppingCartExecutor.Execute();
            StockExecutor.Execute();
        }
    }
}