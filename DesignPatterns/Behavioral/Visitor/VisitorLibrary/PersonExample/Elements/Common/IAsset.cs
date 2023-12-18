using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Elements.Common;

public interface IAsset
{
    // EN: The Component interface declares an `accept` method that should take
    // the base visitor interface as an argument.
    void Accept(IVisitor visitor);
}