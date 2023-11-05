namespace PrototypeLibrary.ComplexUnstableObject;

public class ComplexUnstableObjectExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Complex unstable object example");

        var complicatedObject = new ComplexUnstableObject("a", 'c', "e");

        // Clients from different assembly can't call constructor
        // because it's internal, but they can call Clone.
        var unused = complicatedObject.Clone();
    }
}