using ProxyLibrary.CachingProxyExample;
using ProxyLibrary.LoggingProxyExample;

namespace ProxyLibrary
{
    // Intent: Lets you provide a substitute or placeholder for another object. A
    // proxy controls access to the original object, allowing you to perform
    // something either before or after the request gets through to the original
    // object.
    public class Program
    {
        // EN: The most common applications of the Proxy pattern are lazy
        // loading, caching, controlling the access, logging, etc. A Proxy can
        // perform one of these things and then, depending on the result, pass
        // the execution to the same method in a linked RealSubject object.
        public static void Main(string[] args)
        {
            CachingProxyExecutor.Execute();
            LoggingProxyExecutor.Execute();

        }
    }
}