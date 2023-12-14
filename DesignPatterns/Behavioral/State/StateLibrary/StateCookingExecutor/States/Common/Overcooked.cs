namespace StateLibrary.StateCookingExecutor.States.Common
{
    public class Overcooked : Doneness
    {
        public Overcooked(Doneness state)
            : base(state)
        {
            lowerTemperature = 71;
            upperTemperature = double.MaxValue;
            isSafeToEat = false;
        }

        public override void CheckDoneness()
        {
            if (currentTemperature < lowerTemperature)
            {
                steak.State = new WellDone(this);
            }
        }
    }
}