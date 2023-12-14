using System;

namespace StateLibrary.PackageExample
{
    public static class PackageExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Package Example");

            var package = new Package();
            package.PrintStatus();
            
            package.Proceed();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();
        }
    }
}