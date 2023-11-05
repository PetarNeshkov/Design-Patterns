using PrototypeLibrary.ColorRegistry.Common;

namespace PrototypeLibrary.ColorRegistry;

public class ColorRegistry
{
    private readonly Dictionary<string, IColorPrototype> colors = new();
    
    public IColorPrototype this[string key]
    {
        get => colors[key];
        set => colors[key] = value;
    }
    
    public void List()
    {
        Console.WriteLine("Available colors in the registry...");

        foreach (var color in colors)
        {
            Console.WriteLine($"Name: {color.Key}");
        }
    }
}