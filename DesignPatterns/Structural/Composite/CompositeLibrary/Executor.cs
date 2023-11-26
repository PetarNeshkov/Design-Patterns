using CompositeLibrary.FileSystemExample;
using CompositeLibrary.GiftExample;

namespace CompositeLibrary;

// Intent: Lets you compose objects into tree structures and then work with
// these structures as if they were individual objects.
public class Executor
{
     public static void Main(string[] args)
     {
          FileSystemExecutor.Execute();
          GiftExecutor.Execute();
     }
}