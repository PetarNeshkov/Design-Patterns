using FacadeLibrary.MortgageExample;
using FacadeLibrary.WeatherServiceExample;

namespace FacadeLibrary
{
    public class Program
    {
        // Intent: Provides a simplified interface to a library, a framework, or any
        // other complex set of classes.
        
        // EN: The Facade class provides a simple interface to the complex logic of
        // one or several subsystems. The Facade delegates the client requests to
        // the appropriate objects within the subsystem. The Facade is also
        // responsible for managing their lifecycle. All of this shields the client
        // from the undesired complexity of the subsystem.
        public static void Main(string[] args)
        {
            MortgageExecutor.Execute();
            WeatherServiceExecutor.Execute();
        }
    }
}