namespace ConsoleApp1.Models;

public class Projector : DeviceBase
{
    private float _throwingDistance;
    public float ThrowingDistance
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

    private float _brightness;

    public float Brightness
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

    public Projector(float throwingDistance, float brightness, string name) : base(name)
    {
        ThrowingDistance = throwingDistance;
        Brightness = brightness;
    }
}