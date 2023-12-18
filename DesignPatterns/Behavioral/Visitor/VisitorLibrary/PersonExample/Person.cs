using System.Collections.Generic;
using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample;

// EN: The client code can run visitor operations over any set of
// elements without figuring out their concrete classes. The accept
// operation directs a call to the appropriate operation in the visitor
// object.
//
public class Person
{
    private readonly List<IAsset> assets = new();

    public void RegisterNewAsset(IAsset asset)
        => assets.Add(asset);

    public void InspectAssets(IVisitor visitor)
    {
        foreach (var asset in assets)
        {
            asset.Accept(visitor);
        }
    }
}