using VisitorLibrary.PersonExample.Elements;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Visitors;

// EN: Concrete Visitors implement several versions of the same algorithm,
// which can work with all concrete component classes.
//
// You can experience the biggest benefit of the Visitor pattern when using
// it with a complex object structure, such as a Composite tree. In this
// case, it might be helpful to store some intermediate state of the
// algorithm while executing visitor's methods over various objects of the
// structure.
public class NetWorthVisitor : IVisitor
{
    public int Total { get; private set; }

    public void Visit(RealEstate realEstate) 
        => Total += realEstate.EstimatedValue;

    public void Visit(BankSavingsAccount bankSavingsAccount) 
        => Total += bankSavingsAccount.Amount;

    public void Visit(Loan loan) 
        => Total -= loan.Owed;
}