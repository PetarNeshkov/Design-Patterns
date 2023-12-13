using System;

namespace MementoLibrary.EmployeeExample;

public class EmployeeMemento : IMemento
{
    private string state;
    private DateTime date;
    
    private int Id { get; set; }

    private string Name { get; set; }
    
    private string PhoneNumber { get; set; }
    
    private string Address { get; set; }
    
    public EmployeeMemento(int id,string name, string phoneNumber, string address)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Address = address;
        date = DateTime.Now;
    }


    public string GetState()
        => ToString();

    public DateTime GetDate()
        => date;
    
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Phone: {PhoneNumber}, Address: {Address}, Date: {GetDate()}";
    }
}