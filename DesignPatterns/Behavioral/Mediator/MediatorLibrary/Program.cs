using MediatorLibrary.AirTrafficControl;
using MediatorLibrary.GroupChatExample;

namespace MediatorLibrary
{
    // Intent: Lets you reduce chaotic dependencies between objects. The pattern
    // restricts direct communications between the objects and forces them to
    // collaborate only via a mediator object.
    public class Program
    {
        public static void Main(string[] args)
        {
            AirTrafficControlExecutor.Execute();
            GroupChatExecutor.Execute();
        }
    }
}