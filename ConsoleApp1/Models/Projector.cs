namespace ConsoleApp1.Models;

public class Projector : DeviceBase
{
    private double _throwingDistance;
    public double ThrowingDistance
    {
        get => _throwingDistance;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be > 0");
            } 
            _throwingDistance = value;
        }
    }

    private double _brightness;

    public double Brightness
    {
        get => _brightness;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be > 0");
            }
            _brightness = value;
        }
    }

    public Projector(double throwingDistance, double brightness, string name) : base(name)
    {
        ThrowingDistance = throwingDistance;
        Brightness = brightness;
    }
}