using System;
using System.Collections.Generic;
using System.Linq;
using MediatorLibrary.AirTrafficControl.Components.Common;
using MediatorLibrary.AirTrafficControl.Mediators.Common;

namespace MediatorLibrary.AirTrafficControl.Mediators;

public class FrankfurtAirTrafficControl : IAirTrafficControl
{
    private readonly Dictionary<string, Aircraft> aircraftUnderGuidance = new();

    public void ReceiveAircraftLocation(Aircraft reportingAircraft)
    {
        var potentiallyAffectedAircraft = aircraftUnderGuidance
            .Values
            .Where(a => a.CallSign != reportingAircraft.CallSign);
        
        foreach (var currentAircraft in potentiallyAffectedAircraft)
        {
            if (Math.Abs(currentAircraft.Altitude - reportingAircraft.Altitude) >= 1000)
            {
                continue;
            }

            Console.WriteLine($"\nAir traffic control will issue a warning to {reportingAircraft.CallSign} aircraft about airspace intrusion.");
            currentAircraft.WarnOfAirspaceIntrusionBy(reportingAircraft);
            reportingAircraft.Climb(1000);
        }
    }

    public void RegisterAircraftUnderGuidance(Aircraft aircraft)
    {
        if (!aircraftUnderGuidance.ContainsKey(aircraft.CallSign))
        {
            aircraftUnderGuidance.Add(aircraft.CallSign, aircraft);
        }
    }
}