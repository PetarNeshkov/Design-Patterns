using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Elements;

// EN: Each Concrete Component must implement the `Accept` method in such a
// way that it calls the visitor's method corresponding to the component's
// class.
public class RealEstate : IAsset
{
    public int EstimatedValue { get; set; }
    
    public int MonthlyIncomeFromRenting { get; set; }
    
    public void Accept(IVisitor visitor)
        => visitor.Visit(this);
}