using System;
using StateLibrary.StateCookingExecutor.States.Common;

namespace StateLibrary.StateCookingExecutor
{
    public class Steak
    {
        private readonly string name;
        private Doneness state;

        public Steak(string name, double startingTemperature)
        {
            this.name = name;
            state = new Uncooked(this, startingTemperature);
        }
        
        public double CurrentTemperature => state.CurrentTemperature;

        public Doneness State
        {
            get => state;
            set => state = value;
        }
        
        public void IncreaseTemperature()
        {
            state.IncreaseTemperature();

            Console.WriteLine($"Temperature is increased.");
            Console.WriteLine($"Current temperature is {state.CurrentTemperature}°C");
            Console.WriteLine($"Cooking at this temperature will make the steak: {state.GetType().Name}");
            Console.WriteLine();
        }
        
        public void DecreaseTemperature()
        {
            state.DecreaseTemperature();

            Console.WriteLine($"Temperature is decreased.");
            Console.WriteLine($"Current temperature is {state.CurrentTemperature}°C");
            Console.WriteLine($"Cooking at this temperature will make the steak: {state.GetType().Name}");
            Console.WriteLine();
        }
    }
}