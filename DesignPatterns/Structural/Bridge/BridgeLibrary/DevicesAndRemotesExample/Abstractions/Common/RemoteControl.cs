using BridgeLibrary.DevicesAndRemotesExample.Implementations.Common;

namespace BridgeLibrary.DevicesAndRemotesExample.Abstractions.Common;

/// <summary>
/// The "abstraction" defines the contract for the "control" part of the two class hierarchies.
/// It maintains a reference to an object of the "implementation" hierarchy and delegates
/// all of the real work to this object.
/// </summary>
public abstract class RemoteControl
{
    protected readonly Device device;
    protected readonly int volumeChangeStep;
    
    protected RemoteControl(Device device)
    {
        this.device = device;
        volumeChangeStep = 5;
    }
    
    public void TogglePower()
    {
        if (device.IsTurnedOn)
        {
            device.TurnOff();
            return;
        }

        device.TurnOn();
    }
    
    public void VolumeUp()
    {
        var newVolume = device.Volume + volumeChangeStep;
        if (newVolume > 100)
        {
            newVolume = 100;
        }

        device.Volume = newVolume;
    }
    
    public void VolumeDown()
    {
        var newVolume = device.Volume + volumeChangeStep;
        if (newVolume < 0)
        {
            newVolume = 0;
        }

        device.Volume = newVolume;
    }
    
    public void ChannelUp()
    {
        var newChannel = device.Channel + 1;
        if (newChannel > device.NumberOfChannels)
        {
            newChannel = 1;
        }

        device.Channel = newChannel;
    }

    public void ChannelDown()
    {
        var newChannel = device.Channel - 1;
        if (newChannel < 0)
        {
            newChannel = device.NumberOfChannels;
        }

        device.Channel = newChannel;
    }
}