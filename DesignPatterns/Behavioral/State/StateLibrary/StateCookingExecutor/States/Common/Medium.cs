namespace StateLibrary.StateCookingExecutor.States.Common
{
    public class Medium : Doneness
    {
        public Medium(Doneness state)
            : base(state)
        {
            lowerTemperature = 60;
            upperTemperature = 65;
            isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (currentTemperature < lowerTemperature)
            {
                steak.State = new MediumRare(this);
            }
            else if (currentTemperature > upperTemperature)
            {
                steak.State = new WellDone(this);
            }
        }
    }
}