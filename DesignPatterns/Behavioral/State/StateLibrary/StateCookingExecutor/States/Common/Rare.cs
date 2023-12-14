namespace StateLibrary.StateCookingExecutor.States.Common
{
    public class Rare : Doneness
    {
        public Rare(Doneness state) 
            : base(state)
        {
            lowerTemperature = 49;
            upperTemperature = 55;
            isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (currentTemperature < lowerTemperature)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemperature > upperTemperature)
            {
                steak.State = new MediumRare(this);
            }
        }
    }
}