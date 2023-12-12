using System;
using MediatorLibrary.GroupChatExample.Components.Common;

namespace MediatorLibrary.GroupChatExample.Components;

public class ViberUser : User
{
    public ViberUser(string name) 
        : base(name)
    {
    }

    public override void Send(string message)
    {
        if (mediator == null)
        {
            return;
        }

        Console.WriteLine($"{name} is sending the message: '{message}' to the group");
        mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
        => Console.WriteLine($"{name} received the message: '{message}'");
}