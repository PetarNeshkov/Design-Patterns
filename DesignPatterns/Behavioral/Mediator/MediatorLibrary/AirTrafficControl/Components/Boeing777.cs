using MediatorLibrary.AirTrafficControl.Components.Common;
using MediatorLibrary.AirTrafficControl.Mediators.Common;

namespace MediatorLibrary.AirTrafficControl.Components;

public class Boeing777 : Aircraft
{
    public Boeing777(string callSign, int currentAltitude, IAirTrafficControl airTrafficControl)
        : base(callSign, currentAltitude, airTrafficControl)
    {
    }

    public override int SeatingCapacity => 368;
}