using System;

namespace TemplateMethodLibrary.BreadExample
{
    public static class BreadExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Bread Example");

            var whiteBread = new WhiteBread();
            whiteBread.Make();

            Console.WriteLine();

            var wholeWheatBread = new WholeWheatBread();
            wholeWheatBread.Make();
        }
    }
}