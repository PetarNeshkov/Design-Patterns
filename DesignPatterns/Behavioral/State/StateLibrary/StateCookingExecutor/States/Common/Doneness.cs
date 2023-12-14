namespace StateLibrary.StateCookingExecutor.States.Common
{
    /// <summary>
    /// Doneness is a gauge of how thoroughly cooked a cut of meat is based on
    /// its color, juiciness, and internal temperature when cooked.
    /// In this example we use celsisus degree as a unit of temperature measurement.
    /// </summary>
    public abstract class Doneness
    {
        protected Steak steak;
        protected double currentTemperature;
        protected double lowerTemperature;
        protected double upperTemperature;
        protected bool isSafeToEat;
        protected int temperatureChangeStep;

        protected Doneness(Doneness state)
        {
            this.steak = steak;
            currentTemperature = state.currentTemperature;
            temperatureChangeStep = 1;
        }
        
        protected Doneness(Steak steak)
        {
            this.steak = steak;
            temperatureChangeStep = 1;
        }
        
        public Steak Steak
        {
            get => steak;
            set => steak = value;
        }
        
        public double CurrentTemperature
        {
            get => currentTemperature;
            set => currentTemperature = value;
        }
        
        public virtual void IncreaseTemperature()
        {
            currentTemperature += temperatureChangeStep;
            CheckDoneness();
        }
        
        public virtual void DecreaseTemperature()
        {
            currentTemperature -= temperatureChangeStep;
            CheckDoneness();
        }
        
        public abstract void CheckDoneness();
    }
}