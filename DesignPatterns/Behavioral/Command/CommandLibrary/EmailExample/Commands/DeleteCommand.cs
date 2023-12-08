using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample.Commands
{
    public class DeleteCommand : ICommand
    {
        private readonly Email email;

        public DeleteCommand(Email email)
        {
            this.email = email;
        }

        public void Execute() => email.Delete();
    }
}