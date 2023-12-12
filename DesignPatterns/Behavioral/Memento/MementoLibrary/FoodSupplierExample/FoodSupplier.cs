using System;

namespace MementoLibrary.FoodSupplierExample;

public class FoodSupplier
{
    private string name;
    private string phone;
    private string address;

    public string Name
    {
        get => name;
        set
        {
            name = value;
            Console.WriteLine($"Food supplier: Name is set to {name}");
        }
    }
    
    public string Phone
    {
        get => phone;
        set
        {
            phone = value;
            Console.WriteLine($"Food supplier: Phone Number is set to {phone}");
        }
    }
    
    public string Address
    {
        get => address;
        set
        {
            address = value;
            Console.WriteLine($"Food supplier: Address is set to {address}");
        }
    }
    
    public IMemento Save()
    {
        Console.WriteLine("\nFood supplier: Saving current state...");
        return new FoodSupplierMemento(name, phone, address);
    }
    
    /// <summary>
    /// Restore previous state.
    /// Note that the method returns an IMemento instance in order to to facilitate redo operation.
    /// The return type can be changed to void if redo doesn't have to be supported.
    /// </summary>
    /// <param name="memento">Memento for restoration.</param>
    /// <returns>Redo memento.</returns>
    public IMemento Restore(IMemento memento)
    {
        Console.WriteLine("\nFood supplier: Restoring state...");

        if (memento is not FoodSupplierMemento foodSupplierMemento)
        {
            throw new ArgumentException($"Unknown memento: {memento}");
        }

        var redoMemento = new FoodSupplierMemento(name, phone, address);

        Name = foodSupplierMemento.Name;
        Phone = foodSupplierMemento.PhoneNumber;
        Address = foodSupplierMemento.Address;

        return redoMemento;
    }

}