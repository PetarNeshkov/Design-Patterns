using System;

namespace TemplateMethodLibrary.BreadExample
{
    // The Abstract Class defines a template method that contains a skeleton
    // of some algorithm, composed of calls to (usually) abstract primitive
    // operations.
    //
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact.
    public abstract class Bread
    {
        /// <summary>
        /// The template method.
        /// </summary>
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }

        protected abstract void MixIngredients();

        protected abstract void Bake();

        protected virtual void Slice()
            => Console.WriteLine($"Slicing the {GetType().Name}!");
    }
}