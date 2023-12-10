using System.Collections.Generic;
using System.Text;

namespace InterpreterLibrary
{
    public class ExpressionCreator
    {
        public List<Token> Lex(string input)
        {
            var result = new List<Token>();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '+':
                        result.Add(new Token(Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(Type.Minus, "-"));
                        break;
                    case '(':
                        result.Add(new Token(Type.Lparen, "("));
                        break;
                    case ')':
                        result.Add(new Token(Type.Rparen, ")"));
                        break;
                    default:
                        var sb = new StringBuilder(input[i].ToString());
                        for (int j = i + 1; j < input.Length; j++)
                        {
                            if (char.IsDigit(input[j]))
                            {
                                sb.Append(input[j].ToString());
                                i++;
                            }
                            else
                            {
                                result.Add(new Token(Type.Integer, sb.ToString()));
                                break;
                            }
                        }

                        break;
                }
            }

            return result;
        }
    }
}