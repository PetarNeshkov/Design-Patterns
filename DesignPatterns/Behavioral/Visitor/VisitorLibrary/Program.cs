using VisitorLibrary.CompanyExample;
using VisitorLibrary.PersonDynamicProgrammingExample;
using VisitorLibrary.PersonExample;

namespace VisitorLibrary
{
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