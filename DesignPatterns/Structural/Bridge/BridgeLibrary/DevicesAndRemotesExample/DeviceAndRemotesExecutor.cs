using BridgeLibrary.DevicesAndRemotesExample.Abstractions;
using BridgeLibrary.DevicesAndRemotesExample.Implementations;

namespace BridgeLibrary.DevicesAndRemotesExample;

public static class DeviceAndRemotesExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Devices and remotes example");

        var radioRemote = new UniversalRemoteControl(new SmartTV());
        radioRemote.TogglePower();
        radioRemote.TogglePower();

        Console.WriteLine();

        var advancedRemote = new AdvancedRemoteControl(new SmartTV());
        advancedRemote.TogglePower();
        advancedRemote.Mute();
        advancedRemote.TogglePower();
    }
}