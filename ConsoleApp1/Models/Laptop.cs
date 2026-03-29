namespace ConsoleApp1.Models;

public class Laptop : DeviceBase
{
    private float _batterySize;
    public float BatterySize
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

    private float _screenSize;
    public float ScreenSize
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

    public Laptop(float batterySize, float screenSize, string name) : base(name)
    {
        BatterySize = batterySize;
        ScreenSize = screenSize;
    }
}