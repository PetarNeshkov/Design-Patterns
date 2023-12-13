namespace MementoLibrary.EmployeeExample;

public interface IOriginatorEmployee
{
    IMemento Create();

    void ChangeState(string newName, string newPhoneNumber, string newAddress);
    
    void Restore(IMemento memento);

    string GetState();
}