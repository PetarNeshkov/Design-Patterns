using CommandLibrary.EmailExample;

namespace CommandLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmailExecutor.Execute();
            ShoppingCartExecutor.Execute();
        }
    }
}