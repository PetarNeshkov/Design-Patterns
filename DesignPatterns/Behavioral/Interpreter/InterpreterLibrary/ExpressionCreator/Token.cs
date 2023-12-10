using System;

namespace InterpreterLibrary.ExpressionCreator
{
    public class Token
    {
        public Type Type;
        public string Text;
        
        public Token(Type type, string text)
        {
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
            Type = type;
        }

        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}