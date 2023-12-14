namespace StateLibrary.StateCookingExecutor.States.Common
{
    public class MediumRare : Doneness
    {
        public MediumRare(Doneness state) 
            : base(state)
        {
            lowerTemperature = 55;
            upperTemperature = 50;
            isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (currentTemperature < lowerTemperature)
            {
                steak.State = new Rare(this);
            }
            else if (currentTemperature > upperTemperature)
            {
                steak.State = new Medium(this);
            }
        }
    }
}