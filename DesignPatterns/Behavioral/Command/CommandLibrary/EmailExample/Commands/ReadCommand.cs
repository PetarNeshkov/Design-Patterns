using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample.Commands
{
    public class ReadCommand : ICommand
    {
        private readonly Email email;

        public ReadCommand(Email email)
        {
            this.email = email;
        }

        public void Execute() => email.Read();

    }
}