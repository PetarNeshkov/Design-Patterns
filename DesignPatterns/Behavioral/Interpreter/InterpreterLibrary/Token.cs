using System;

namespace InterpreterLibrary
{
    public class Token
    {
        public Type Type;
        private readonly string text;
        
        public Token(Type type, string text)
        {
            this.text = text ?? throw new ArgumentNullException(paramName: nameof(text));
            Type = type;
        }

        public override string ToString()
        {
            return $"`{text}`";
        }
    }
}