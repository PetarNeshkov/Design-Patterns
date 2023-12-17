using TemplateMethodLibrary.BreadExample;
using TemplateMethodLibrary.ConceptualExample;

namespace TemplateMethodLibrary
{
    // Intent: Defines the skeleton of an algorithm in the superclass but lets
    // subclasses override specific steps of the algorithm without changing its
    // structure.
    public class Program
    {
        public static void Main(string[] args)
        {
            BreadExecutor.Execute();
            ConceptualExecutor.Execute();
        }
    }
}