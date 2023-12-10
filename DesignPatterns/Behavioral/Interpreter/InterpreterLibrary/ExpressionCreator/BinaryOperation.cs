using System;

namespace InterpreterLibrary.ExpressionCreator
{
    public class BinaryOperation : IElement
    {
        public Type MyType;
        public IElement Left;
        public IElement Right;

        public int Value
        {
            get
            {
                switch (MyType)
                {
                    case Type.Addition:
                        return Left.Value + Right.Value;
                    case Type.Subtraction:
                        return Left.Value - Right.Value;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}