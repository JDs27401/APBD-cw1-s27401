namespace ConsoleApp1.Models;

public class Laptop : DeviceBase
{
    private double _batterySize;
    public double BatterySize
    {
        get => _batterySize;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be > 0");
            } 
            _batterySize = value;
        }
    }

    private double _screenSize;
    public double ScreenSize
    {
        get => _screenSize;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be > 0");
            }
            _screenSize = value;
        }
    }

    public Laptop(double batterySize, double screenSize, string name) : base(name)
    {
        BatterySize = batterySize;
        ScreenSize = screenSize;
    }
}