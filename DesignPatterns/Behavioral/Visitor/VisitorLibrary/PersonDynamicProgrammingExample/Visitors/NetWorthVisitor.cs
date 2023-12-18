using VisitorLibrary.PersonDynamicProgrammingExample.Elements;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Visitors;

public class NetWorthVisitor : AssetVisitor
{
    public int Total { get; private set; }

    protected override void Visit(BankSavingsAccount bankSavingsAccount)
        => Total += bankSavingsAccount.Amount;

    protected override void Visit(Loan loan)
        => Total -= loan.Owed;

    protected override void Visit(RealEstate realEstate)
        => Total += realEstate.EstimatedValue;
}