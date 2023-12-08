using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample.Commands
{
    public class ForwardCommand : ICommand
    {
        private readonly Email email;

        public ForwardCommand(Email email)
        {
            this.email = email;
        }

        public void Execute()
            => email.Forward();
    }
}