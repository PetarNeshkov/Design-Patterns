using VisitorLibrary.PersonExample.Elements;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Visitors;

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