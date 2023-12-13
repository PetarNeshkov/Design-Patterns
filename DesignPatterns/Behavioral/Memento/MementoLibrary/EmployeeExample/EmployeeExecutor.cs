using System;

namespace MementoLibrary.EmployeeExample;

public static class EmployeeExecutor
{
    public static void Execute()
    {
        OriginatorEmployee employee1 = new OriginatorEmployee(1,"John Doe", "555-0100", "123 Elm St");
        OriginatorEmployee employee2 = new OriginatorEmployee(2,"Jane Smith", "555-0200", "456 Oak St");

        // Create caretaker and add originators with unique IDs
        CareTakerEmployee caretaker = new CareTakerEmployee();
        caretaker.AddOriginator(1, employee1);
        caretaker.AddOriginator(2, employee2);

        // Save initial states
        caretaker.AddMemento(1);
        caretaker.AddMemento(2);

        // Change states and save them
        employee1.ChangeState("John Doe", "555-1111", "789 Pine St");
        caretaker.AddMemento(1);
        employee2.ChangeState("Jane Smith", "555-2222", "321 Maple St");
        caretaker.AddMemento(2);

        // Display current details
        Console.WriteLine(employee1.GetState());
        Console.WriteLine(employee2.GetState());

        // Undo the changes
        caretaker.Undo(1);
        caretaker.Undo(2);

        // Display details after undo
        Console.WriteLine(employee1);
        Console.WriteLine(employee2);

        // Show history of changes
        caretaker.ShowHistory(1);
        caretaker.ShowHistory(2);
    }
}