using VisitorLibrary.CompanyExample;
using VisitorLibrary.PersonDynamicProgrammingExample;
using VisitorLibrary.PersonExample;

namespace VisitorLibrary
{
    // Intent: Lets you separate algorithms from the objects on which they operate.
    public class Program
    {
        public static void Main(string[] args)
        {
            CompanyExecutor.Execute();
            PersonDynamicProgrammingExecutor.Execute();
            PersonExecutor.Execute();
        }
    }
}