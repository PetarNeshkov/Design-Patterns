using StateLibrary.ConceptualExample;
using StateLibrary.PackageExample;
using StateLibrary.PackageExample.States.Common;
using StateLibrary.StateCookingExecutor.States;

namespace StateLibrary
{
    // Intent: Lets an object alter its behavior when its internal state changes. It
    // appears as if the object changed its class.
    public class Program
    {
        public static void Main(string[] args)
        {
            ConceptualExecutor.Execute();
            PackageExecutor.Execute();
            SteakCookingExecutor.Execute();
        }
    }
}