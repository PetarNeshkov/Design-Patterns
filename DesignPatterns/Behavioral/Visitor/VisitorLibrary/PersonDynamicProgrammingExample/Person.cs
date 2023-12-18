using System.Collections.Generic;
using VisitorLibrary.PersonDynamicProgrammingExample.Elements.Common;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample;

public class Person
{
    private readonly List<IAsset> assets = new();

    public void RegisterNewAsset(IAsset asset) 
        => assets.Add(asset);

    public void InspectAssets(AssetVisitor visitor) 
        => visitor.Visit(assets);
    // It is possible to use this approach too.
    // foreach (var asset in Assets)
    // {
    //     visitor.DynamicVisit(asset);
    // }
}