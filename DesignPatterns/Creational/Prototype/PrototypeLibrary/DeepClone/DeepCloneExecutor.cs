using PrototypeLibrary.DeepClone.Models;
using OperatingSystem = PrototypeLibrary.DeepClone.Models.OperatingSystem;

namespace PrototypeLibrary.DeepClone;

public static class DeepCloneExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Deep clone example");
        
        var phone = new MobilePhone
        {
            Manufacturer = "Samsung",
            Model = "Note 9",
            OperatingSystem = new OperatingSystem
            {
                Name = "Android",
                Version = "11",
                Description = "Android is a mobile OS based on a modified version of the Linux kernel and other open source software, designed primarily for touchscreen mobile devices such as smartphones and tablets. ",
            },
        };

        var clonedPhone = phone.Clone();
        clonedPhone.Model = "Samsung Note 10";
        
        phone.PrintDetails();
        clonedPhone.PrintDetails();
    }
}