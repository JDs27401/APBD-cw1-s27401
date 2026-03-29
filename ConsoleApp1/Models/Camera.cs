namespace ConsoleApp1.Models;

public class Camera : DeviceBase
{
    private double _sensorSize;

    public double SensorSize
    {
        get => _sensorSize;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be > 0");
            } 
            _sensorSize = value;
        }
    }

    private int _maxIso;

    public int MaxIso
    {
        get => _maxIso;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("value must be > 0");
            } 
            _maxIso = value;
        }
    }

    public Camera(float sensorSize, int maxIso, string name) : base(name)
    {
        SensorSize = sensorSize;
        MaxIso = maxIso;
    }
}