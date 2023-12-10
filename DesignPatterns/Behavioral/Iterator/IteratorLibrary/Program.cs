using IteratorLibrary.ConceptualExample;

namespace IteratorLibrary
{
    // Intent: Lets you traverse elements of a collection without exposing its
    // underlying representation (list, stack, tree, etc.).
    public class Program
    {
        // EN: The client code may or may not know about the Concrete
        // Iterator or Collection classes, depending on the level of
        // indirection you want to keep in your program.
        public static void Main(string[] args)
        {
            ConceptualExecutor.Execute();
        }
    }
}