namespace ConsoleApp1.Models;

public abstract class DeviceBase
{
    private static int _mainId = 1;
    
    public string Id { get; } = "ID" + _mainId++;
}