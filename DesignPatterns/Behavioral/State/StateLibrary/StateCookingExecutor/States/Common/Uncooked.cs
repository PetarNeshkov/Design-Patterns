namespace StateLibrary.StateCookingExecutor.States.Common
{
    public class Uncooked : Doneness
    {
        public Uncooked(Steak steak, double currentTemperature) 
            : base(steak)
        {
            this.currentTemperature = currentTemperature;
            lowerTemperature = 0;
            upperTemperature = 49;
            isSafeToEat = false;
        }

        public Uncooked(Doneness state) 
            : this(state.Steak, state.CurrentTemperature)
        {
        }

        public override void CheckDoneness()
        {
            if (currentTemperature > upperTemperature)
            {
                steak.State = new Rare(this);
            }
        }
    }
}