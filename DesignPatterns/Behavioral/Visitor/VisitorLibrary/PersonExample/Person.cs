using System.Collections.Generic;
using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample;

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