using System.Linq.Expressions;
using VisitorLibrary.CompanyExample;
using VisitorLibrary.PersonDynamicProgrammingExample;

namespace VisitorLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CompanyExecutor.Execute();
            PersonDynamicProgrammingExecutor.Execute();
        }
    }
}