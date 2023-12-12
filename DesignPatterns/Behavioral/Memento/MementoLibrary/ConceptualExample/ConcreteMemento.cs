using System;

namespace MementoLibrary.ConceptualExample
{
    /// <summary>
    /// The Concrete Memento contains the infrastructure for storing the Originator's state.
    /// The Memento object acts as a snapshot of the originator’s state.
    /// It’s a common practice to make the memento immutable and
    /// pass it the data only once, via the constructor.
    /// </summary>
    public class ConcreteMemento : IMemento
    {
        private readonly string state;
        private readonly DateTime creationDate;

        public ConcreteMemento(string state)
        {
            this.state = state;
            creationDate = DateTime.Now;
        }
        
        /// <summary>
        /// Used by the Caretaker to display metadata.
        /// </summary>
        /// <returns>Creation date.</returns>
        public DateTime GetCreationDate() => creationDate;

        /// <summary>
        /// Used by the Caretaker to display metadata.
        /// </summary>
        /// <returns>Name.</returns>
        public string GetName() 
            => $"{creationDate:MM/dd/yyyy hh:mm:ss.fff tt} " +
               $"/ ({state.Substring(0, Math.Min(10, state.Length))}";
        
        /// <summary>
        /// The Originator uses this method when restoring its state.
        /// </summary>
        /// <returns>State.</returns>
        public string GetState() => state;
    }
}