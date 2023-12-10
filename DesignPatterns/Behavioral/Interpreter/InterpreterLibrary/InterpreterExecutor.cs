using System;

namespace InterpreterLibrary
{
    public static class InterpreterExecutor
    {
        public static void Execute()
        {
            var input = "(13+4)-(12+1)";

            var expressionCreator = new ExpressionCreator();
            var tokens = expressionCreator.Lex(input);

            Console.WriteLine(string.Join("\t", tokens));
        }
    }
}