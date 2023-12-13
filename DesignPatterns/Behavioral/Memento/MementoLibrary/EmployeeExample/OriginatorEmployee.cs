using System;

namespace MementoLibrary.EmployeeExample;

public class OriginatorEmployee : IOriginatorEmployee
{
    private int id;
    private string name;
    private string phoneNumber;
    private string address;

    public OriginatorEmployee(int id,string name, string phoneNumber, string address)
    {
        this.id = id;
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.address = address;

        Console.WriteLine("Originator: My initial state is: " + GetState());
    }

    public IMemento Create()
        => new EmployeeMemento(id,name, phoneNumber, address);


    public void ChangeState(string newName, string newPhoneNumber, string newAddress)
    {
        name = newName;
        phoneNumber = newPhoneNumber;
        address = newAddress;
        
        Console.WriteLine($"Originator: My state has changed to: {GetState()}");;
    }

    public void Restore(IMemento memento)
    {
        if (memento is not EmployeeMemento concreteMemento)
        {
            throw new ArgumentException("Unknown memento class", nameof(memento));
        }

        id =  int.Parse(concreteMemento.GetState().Split(',')[0].Split(':')[1].Trim());
        name = concreteMemento.GetState().Split(',')[1].Split(':')[1].Trim();
        phoneNumber = concreteMemento.GetState().Split(',')[2].Split(':')[1].Trim();
        address = concreteMemento.GetState().Split(',')[3].Split(':')[1].Trim();
        
        Console.WriteLine($"Originator: My state has been restored to: {GetState()}");
    }

    public string GetState()
    {
        return $"Id: {id}, Name: {name}, Phone: {phoneNumber}, Address: {address}";
    }
}