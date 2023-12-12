using MediatorLibrary.AirTrafficControl.Components.Common;
using MediatorLibrary.AirTrafficControl.Mediators.Common;

namespace MediatorLibrary.AirTrafficControl.Components;

public class AirbusA320 : Aircraft
{
    public AirbusA320(string callSign, int currentAltitude, IAirTrafficControl airTrafficControl) 
        : base(callSign, currentAltitude, airTrafficControl)
    {
    }

    public override int SeatingCapacity => 180;
}