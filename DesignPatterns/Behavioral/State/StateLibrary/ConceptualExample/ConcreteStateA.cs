using System;
using StateLibrary.ConceptualExample.Common;

namespace StateLibrary.ConceptualExample
{
    /// <summary>
    /// Concrete States implement various behaviors, associated with a state of the Context.
    /// </summary>
    public class ConcreteStateA : State
    {
        public override void Handle1()
        {
            if (context == null)
            {
                return;
            }

            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");

            context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
            => Console.WriteLine("ConcreteStateA handles request2.");
    }
}