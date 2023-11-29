using DecoratorLibrary.PancakeExample.Components.Common;

namespace DecoratorLibrary.PancakeExample.Decorators.Common
{
    public class PancakeDecorator : Pancake
    {
        private readonly Pancake pancake;
        
        public PancakeDecorator(Pancake pancake)
        {
            this.pancake = pancake;
        }

        public override double CalculatePrice()
            => pancake.CalculatePrice();

        public override string GetDescriptionAndAddIns() 
            => $"{pancake.GetDescriptionAndAddIns()}, {Description}";

    }
}