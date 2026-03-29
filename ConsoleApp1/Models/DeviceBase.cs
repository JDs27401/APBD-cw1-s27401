using ConsoleApp1.Enums;
using ConsoleApp1.Services;

namespace ConsoleApp1.Models;

public abstract class DeviceBase : IReservation
{
    public ICollection<DeviceBase> Devices { get; } = new List<DeviceBase>();
    
    private static int _mainId = 1;
    public string Id { get; } = "ID" + _mainId++;
    
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            _name = value;
        }
    }
    public DeviceStatus DeviceStatus { get; set; }

    private Reservation? _reservation;
    public Reservation Reservation
    {
        get => _reservation;
        set
        {
            if (_reservation != null)
            {
                throw new Exception("The reservation has already been assigned.");
                //@todo implement own Exception
            }
            _reservation = value;
        }
    }

    protected DeviceBase(string name)
    {
        Name = name;
    }

    public void AddReservation(Reservation reservation)
    {
        _reservation = reservation;
    }

    public void RemoveReservation(Reservation reservation)
    {
        _reservation = null;
    }
}