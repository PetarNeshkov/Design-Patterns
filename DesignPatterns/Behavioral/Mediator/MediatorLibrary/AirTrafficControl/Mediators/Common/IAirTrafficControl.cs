using MediatorLibrary.AirTrafficControl.Components.Common;

namespace MediatorLibrary.AirTrafficControl.Mediators.Common;

public interface IAirTrafficControl
{
    void ReceiveAircraftLocation(Aircraft reportingAircraft);
    
    void RegisterAircraftUnderGuidance(Aircraft aircraft);
}