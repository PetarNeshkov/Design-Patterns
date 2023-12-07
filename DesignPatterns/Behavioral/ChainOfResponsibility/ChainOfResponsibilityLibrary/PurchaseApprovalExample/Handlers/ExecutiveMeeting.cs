using System;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers;

public class ExecutiveMeeting : Approver
{
    public static readonly ExecutiveMeeting Instance = new();

    private ExecutiveMeeting()
    {
    }
    
    public override void Approve(Purchase purchase)
        => Console.WriteLine(
            $"The purchase #{purchase.Number} which cost {purchase.Cost:C} requires " +
            "an executive meeting in order to be approved.");
    
}