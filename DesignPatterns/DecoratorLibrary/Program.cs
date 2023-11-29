using DecoratorLibrary.DataStorageExample;
using DecoratorLibrary.PancakeExample;

namespace DecoratorLibrary
{
    // Intent: Lets you attach new behaviors to objects by placing these objects
    // inside special wrapper objects that contain the behaviors.
    public class Program
    {
        public static void Main(string[] args)
        {
            DataStorageExecutor.Execute();
            PancakeExecutor.Execute();
        }
    }
}