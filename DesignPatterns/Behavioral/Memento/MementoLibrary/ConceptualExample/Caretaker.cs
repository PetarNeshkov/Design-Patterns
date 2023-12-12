using System;
using System.Collections.Generic;

namespace MementoLibrary.ConceptualExample;

/// <summary>
/// The Caretaker doesn't depend on the Concrete Memento class.
/// Therefore, it doesn't have access to the originator's state, stored inside the memento.
/// It works with all mementos via the base Memento interface.
/// </summary>
public class Caretaker
{
    private readonly Stack<IMemento> mementos;
    private readonly Originator originator;

    public Caretaker(Originator originator)
    {
        this.originator = originator;
        mementos = new Stack<IMemento>();
    }
    
    public void Backup()
    {
        Console.WriteLine("Caretaker: Saving Originator's state...");

        mementos.Push(originator.Save());
    }
    
    public void Undo()
    {
        if (mementos.Count == 0)
        {
            return;
        }

        var memento = mementos.Pop();
        Console.WriteLine($"Caretaker: Restoring state to: {memento.GetName()}");
        originator.Restore(memento);
    }
    
    public void ShowHistory()
    {
        Console.WriteLine("\nCaretaker: Here's the list of mementos:");

        foreach (var memento in mementos)
        {
            Console.WriteLine(memento.GetName());
        }
    }
}