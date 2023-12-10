using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterLibrary.ExpressionCreator
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
        
          public IElement Parse(IReadOnlyList<Token> tokens)
        {
            var result = new BinaryOperation();
            var haveLHS = false;
            for (int i = 0; i < tokens.Count; i++)
            {
                var token = tokens[i];

                switch (token.Type)
                {
                    case Type.Integer:
                        var tokenToInt = int.Parse(token.Text);
                        var integer = new Integer(tokenToInt);
                        if (!haveLHS)
                        {
                            result.Left = integer;
                            haveLHS = true;
                        }
                        else
                        {
                            result.Right = integer;
                        }
                        break;
                    case Type.Plus:
                        result.MyType = Type.Addition;
                        break; 
                    case Type.Minus:
                        result.MyType = Type.Subtraction;
                        break; 
                    case Type.Lparen:
                        int j = i;
                        int parenCount = 1;
                        while (j < tokens.Count)
                        {
                            j++;
                            if (tokens[j].Type == Type.Lparen) parenCount++;
                            if (tokens[j].Type == Type.Rparen) parenCount--;

                            if (parenCount == 0) break;
                        }

                        var subExpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
                        var element = Parse(subExpression);

                        if (!haveLHS)
                        {
                            result.Left = element;
                            haveLHS = true;
                        }
                        else
                        {
                            result.Right = element;
                        }

                        i = j;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

            }
            return result;
        }
    }
}