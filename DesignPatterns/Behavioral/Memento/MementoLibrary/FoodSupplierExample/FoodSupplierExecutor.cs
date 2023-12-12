using System;

namespace MementoLibrary.FoodSupplierExample;

public class FoodSupplierExecutor
{
    public static void Execute()
    {
        Console.WriteLine("\nFood supplier example");
        
        var foodSupplier = new FoodSupplier
        {
            Name = "Nikola Pupin",
            Phone = "+38164 111111",
            Address = "Dunavska 10, Novi Sad",
        };

        var registry = new SupplierRegistry(foodSupplier);
        registry.Backup();

        foodSupplier.Phone = "+38164 222222";

        registry.Undo();
        registry.Redo();
    }
}