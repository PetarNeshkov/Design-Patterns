using System;
using System.Collections.Generic;
using MementoLibrary.ConceptualExample;

namespace MementoLibrary.EmployeeExample;

public class CareTakerEmployee
{
    private readonly Dictionary<int, Stack<IMemento>> mementos;
    private readonly Dictionary<int, IOriginatorEmployee> originators;

    public CareTakerEmployee()
    {
        mementos = new Dictionary<int, Stack<IMemento>>();
        originators = new Dictionary<int, IOriginatorEmployee>();
    }
    
    public void AddOriginator(int id, IOriginatorEmployee originator)
    {
        originators[id] = originator;
    }
    
    public void AddMemento(int id)
    {
        if (!mementos.ContainsKey(id))
        {
            mementos[id] = new Stack<IMemento>();
        }
        
        mementos[id].Push(originators[id].Create());
    }

    public void Undo(int id)
    {
        if (!mementos.ContainsKey(id) || mementos[id].Count == 0)
        {
            Console.WriteLine("Caretaker: No mementos to restore state.");
            
            return;
        }

        var memento = mementos[id].Pop();

        Console.WriteLine($"Caretaker: Restoring state to: {memento.GetState()}");
        originators[id].Restore(memento);
    }
    
    public void ShowHistory(int id)
    {
        Console.WriteLine($"Caretaker: Showing history for originator with ID {id}:");
        foreach (var memento in mementos[id])
        {
            Console.WriteLine(memento.GetState() + " at " + memento.GetDate());
        }
    }
}