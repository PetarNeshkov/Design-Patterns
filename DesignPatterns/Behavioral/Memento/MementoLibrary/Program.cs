using MementoLibrary.ConceptualExample;
using MementoLibrary.FoodSupplierExample;

namespace MementoLibrary
{
    // Intent: Lets you save and restore the previous state of an object without
    // revealing the details of its implementation.
    public class Program
    {
        public static void Main(string[] args)
        {
            ConceptualExecutor.Execute();
            FoodSupplierExecutor.Execute();
        }
    }
}