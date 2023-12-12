using System;
using System.Collections.Generic;

namespace MementoLibrary.FoodSupplierExample;

/// <summary>
/// A caretaker can keep track of the originator’s history by storing a stack of mementos.
/// </summary>
public class SupplierRegistry
{
    private readonly FoodSupplier supplier;
    private readonly Stack<IMemento> undoStack;
    private readonly Stack<IMemento> redoStack;
    
    public SupplierRegistry(FoodSupplier supplier)
    {
        this.supplier = supplier;
        undoStack = new Stack<IMemento>();
        redoStack = new Stack<IMemento>();
    }
    
    public void Backup()
    {
        Console.WriteLine("\nSupplier registry: Performing backup operation...");

        redoStack.Clear();
        undoStack.Push(supplier.Save());
    }
    
    public void Undo()
    {
        Console.WriteLine("\nSupplier registry: Performing undo operation...");

        var top = undoStack.Pop();
        redoStack.Push(supplier.Restore(top));
    }
    
    public void Redo()
    {
        Console.WriteLine("\nSupplier registry: Performing redo operation...");

        var top = redoStack.Pop();
        undoStack.Push(supplier.Restore(top));
    }
}