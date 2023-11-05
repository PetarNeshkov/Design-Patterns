namespace PrototypeLibrary.LogicPuzzle;

public class LogicPuzzle: ICloneable
{
    private int  blueSwitchCharge;
    private int  redSwitchCharge;
    private bool smallToggle;
    private bool bigToggle;
    private bool doorOpen;
    private bool slatLocked;
    private int  moveCount;
    
    public void SwitchBlueSwitch()
    {
        if (smallToggle)
        {
            blueSwitchCharge++;
        }

        bigToggle = !bigToggle;
        moveCount++;
    }
    
    public void SwitchRedSwitch()
    {
        if (!smallToggle && blueSwitchCharge < 3)
        {
            doorOpen = true;
            blueSwitchCharge = 0;
        }
        else
        {
            redSwitchCharge++;
            slatLocked = true;
            smallToggle = !smallToggle;
        }

        moveCount++;
    }
    
    public void ToggleBigToggle()
    {
        if (doorOpen)
        {
            doorOpen = false;
        }

        slatLocked = false;
        redSwitchCharge = 0;
        moveCount++;
    }
    
    public void ToggleSmallToggle()
    {
        if (blueSwitchCharge < 3 || redSwitchCharge > 5)
        {
            slatLocked = false;
            doorOpen = true;
        }

        moveCount++;
    }
    
    public void PrintState()
    {
        Console.WriteLine($"Blue switch charge: {blueSwitchCharge}");
        Console.WriteLine($"Red switch charge: {redSwitchCharge}");
        Console.WriteLine($"Small toggle: {smallToggle}");
        Console.WriteLine($"Big toggle: {bigToggle}");
        Console.WriteLine($"Door open: {doorOpen}");
        Console.WriteLine($"Slat locked: {slatLocked}");
        Console.WriteLine($"Move count: {moveCount}");
    }
    
    public object Clone() => MemberwiseClone();
}