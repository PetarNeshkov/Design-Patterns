using System;

namespace MementoLibrary.EmployeeExample;

public interface IMemento
{
    string GetState();
    
    DateTime GetDate();
}