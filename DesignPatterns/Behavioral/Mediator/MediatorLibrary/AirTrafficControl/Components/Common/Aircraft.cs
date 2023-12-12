using System;
using MediatorLibrary.AirTrafficControl.Mediators.Common;

namespace MediatorLibrary.AirTrafficControl.Components.Common
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl airTrafficControl;
        private int currentAltitude;

        protected Aircraft(string callSign, int currentAltitude, IAirTrafficControl airTrafficControl)
        {
            CallSign = callSign;
            
            // In this example, IAirTrafficControl interface is passed to components and components are responsible to register themselves to the mediator.
            // Be careful with this approach, since the object that is passed to the mediator (this) might not be fully initialized.
            // This might not be the best approach for the AirTrafficControlExample, but it's shown for demo purposes as one of possibilities.
            // Take a look at GroupChatExample for a different approach.
            this.airTrafficControl = airTrafficControl;
            airTrafficControl.RegisterAircraftUnderGuidance(this);
            Altitude = currentAltitude;
        }
        
        public abstract int SeatingCapacity { get; }

        public string CallSign { get; }
        
        public int Altitude
        {
            get => currentAltitude;
            set
            {
                currentAltitude = value;
                Console.WriteLine($"Aircraft with the call sign {CallSign} flies at {currentAltitude} feet.");

                airTrafficControl.ReceiveAircraftLocation(this);
            }
        }
        
        public void Climb(int heightToClimb) => Altitude += heightToClimb;

        public override bool Equals(object obj)
        {
            if (obj is not Aircraft incoming)
            {
                return false;
            }

            return CallSign.Equals(incoming.CallSign, StringComparison.Ordinal);
        }

        public override int GetHashCode() => CallSign.GetHashCode();

        public void WarnOfAirspaceIntrusionBy(Aircraft aircraft) 
            =>
            // Do something in response to the warning.
            Console.WriteLine($"Aircraft {CallSign} has received notification about airspace intrusion by {aircraft.CallSign}.");
    }
}