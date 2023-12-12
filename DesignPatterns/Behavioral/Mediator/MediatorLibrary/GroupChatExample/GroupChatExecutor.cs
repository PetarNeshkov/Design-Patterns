using System;
using MediatorLibrary.GroupChatExample.Components;
using MediatorLibrary.GroupChatExample.Mediators;
using MediatorLibrary.GroupChatExample.Mediators.Common;

namespace MediatorLibrary.GroupChatExample;

public class GroupChatExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Group chat example");

        var mark = new ViberUser("Mark");
        var jane = new ViberUser("Jane");
        var emily = new ViberUser("Emily");
        IGroupChatMediator mediator = new ViberGroupChatMediator(mark, jane, emily);

        mark.Send("Is anyone there?");
        Console.WriteLine();

        var anna = new ViberUser("Anna");
        mediator.AddParticipant(anna);

        emily.Send("We are here.");
        
    }
}