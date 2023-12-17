using System;

namespace TemplateMethodLibrary.ConceptualExample
{
    public static class ConceptualExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Conceptual example");

            Console.WriteLine("Working with concrete class 1...");
            Client.ProcessSomething(new ConcreteClass1());

            Console.WriteLine("\nWorking with concrete class 2...");
            Client.ProcessSomething(new ConcreteClass2());
        }
    }
}