using System.Collections.Generic;
using System.Linq;
using CommandLibrary.ShoppingCartExample.Commands.Common;

namespace CommandLibrary.ShoppingCartExample;

public class CommandManager
{
    private readonly Stack<ICommand> commands = new();

    public void Invoke(ICommand command)
    {
        if (!command.CanExecute())
        {
            return;
        }

        commands.Push(command);
        command.Execute();
    }
    
    public void Undo()
    {
        if (!commands.Any())
        {
            return;
        }

        var command = commands.Pop();
        command.Undo();
    }
}