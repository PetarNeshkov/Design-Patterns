using System;

namespace StateLibrary.ConceptualExample
{
    public static class ConceptualExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Conceptual example");
            
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}