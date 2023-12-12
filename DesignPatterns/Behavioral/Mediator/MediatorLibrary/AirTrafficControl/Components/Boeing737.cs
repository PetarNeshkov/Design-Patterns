using MediatorLibrary.AirTrafficControl.Components.Common;
using MediatorLibrary.AirTrafficControl.Mediators.Common;

namespace MediatorLibrary.AirTrafficControl.Components;

public class Boeing737 : Aircraft
{
    public Boeing737(string callSign, int currentAltitude, IAirTrafficControl airTrafficControl) 
        : base(callSign, currentAltitude, airTrafficControl)
    {
    }

    public override int SeatingCapacity => 143;
}