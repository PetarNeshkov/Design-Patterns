namespace StateLibrary.StateCookingExecutor.States.Common
{
    public class WellDone : Doneness
    {
        public WellDone(Doneness state)
            : base(state)
        {
            lowerTemperature = 65;
            upperTemperature = 71;
            isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (currentTemperature < lowerTemperature)
            {
                steak.State = new Medium(this);
            }
            else if (currentTemperature > upperTemperature)
            {
                steak.State = new Overcooked(this);
            }
        }
    }
}