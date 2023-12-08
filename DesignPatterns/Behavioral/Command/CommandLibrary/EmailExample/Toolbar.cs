using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample
{
    public class Toolbar
    {
        private readonly ICommand readCommand;
        private readonly ICommand forwardCommand;
        private readonly ICommand deleteCommand;

        public Toolbar(ICommand readCommand, ICommand forwardCommand, ICommand deleteCommand)
        {
            this.readCommand = readCommand;
            this.forwardCommand = forwardCommand;
            this.deleteCommand = deleteCommand;
        }
        
        public void ReadEmail() => readCommand.Execute();

        public void ForwardEmail() => forwardCommand.Execute();

        public void DeleteEmail() => deleteCommand.Execute();
    }
}