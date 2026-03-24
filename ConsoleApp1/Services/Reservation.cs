using ConsoleApp1.Models;

namespace ConsoleApp1.Services;

public class Reservation
{
    public static Dictionary<string, DeviceBase> Reservations = new Dictionary<string, DeviceBase>();
    private static int _mainId = 1;
    public string Id { get; } = "R" + _mainId++;
    
    public ICollection<DeviceBase> Devices { get; } = new List<DeviceBase>();

    public Person Owner { get; }

    private Reservation(DeviceBase[] devices, Person person, DateTime reservationDate, DateTime reservationEndDate)
    {
        //@todo implement a constructor with assignments for all variables
    }
    
    //@todo implement functions for creating and resolving reservation
    //@todo add enum with status for active and finished reservations
}