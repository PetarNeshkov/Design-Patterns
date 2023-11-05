namespace PrototypeLibrary.ColorRegistry.Common;

/// <summary>
/// The Prototype interface declares the cloning methods.
/// In most cases, it’s a single Clone method.
/// Instead of manually defining interface, we can use <see cref="ICloneable"/>.
/// </summary>
public interface IColorPrototype
{
    IColorPrototype Clone();
}