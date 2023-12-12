using MediatorLibrary.GroupChatExample.Mediators.Common;

namespace MediatorLibrary.GroupChatExample.Components.Common;

public abstract class User
{
    protected IGroupChatMediator? mediator;
    protected string name;

    public User(string name)
    {
        this.name = name;
    }

    public string Name => name;

    public void SetMediator(IGroupChatMediator mediatorToSet)
        => mediator = mediatorToSet;
    
    public abstract void Send(string message);
    public abstract void Receive(string message);
}