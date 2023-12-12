using MediatorLibrary.AirTrafficControl.Components.Common;

namespace MediatorLibrary.AirTrafficControl.Mediators.Common;

// EN: The Mediator interface declares a method used by components to notify
// the mediator about various events. The Mediator may react to these events
// and pass the execution to other components.
public interface IAirTrafficControl
{
    void ReceiveAircraftLocation(Aircraft reportingAircraft);
    
    void RegisterAircraftUnderGuidance(Aircraft aircraft);
}