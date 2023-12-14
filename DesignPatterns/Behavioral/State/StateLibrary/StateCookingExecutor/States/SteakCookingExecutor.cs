using System;

namespace StateLibrary.StateCookingExecutor.States
{
    public static class SteakCookingExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Steak cooking example");
            
            var steak = new Steak("T-Bone", 48);

            steak.IncreaseTemperature();
            steak.IncreaseTemperature();
        }
    }
}