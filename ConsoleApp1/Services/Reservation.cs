using ConsoleApp1.Enums;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services;

public class Reservation
{
    public static Dictionary<string, Reservation> Reservations { get; }  = new Dictionary<string, Reservation>();
    private static int _mainId = 1;
    public string Id { get; } = "R" + _mainId++;
    
    public ICollection<DeviceBase> Devices { get; } = new List<DeviceBase>();
    public Person? Owner { get; }
    public ReservationStatus Status { get; set; }
    public DateTime ReservationDate { get; }
    public DateTime ReservationEndDate { get; }

    private Reservation(Person person, DeviceBase[] devices, DateTime reservationDate, DateTime reservationEndDate)
    {
        Owner = person;
        foreach (DeviceBase device in devices)
        {
            Devices.Add(device);
        }
        ReservationDate = reservationDate;
        ReservationEndDate = reservationEndDate;
        Status = ReservationStatus.Ongoing;
        Reservations.Add(Id, this);
    }


    public void CreateReservation(Person person, DeviceBase[] devices, DateTime reservationDate, DateTime reservationEndDate)
    {
        if (person.CurrentReservations >= person.MaxReservations)
        {
            throw new MaxReservationsReachedException("Max reservations reached");
        }

        if (reservationDate >= reservationEndDate)
        {
            throw new Exception("Reservation date is the same as reservation end date");
        }

        if (devices.Length == 0)
        {
            throw new Exception("No devices added");
        }

        foreach (var d in devices)
        {
            if (d.DeviceStatus != DeviceStatus.Available)
            {
                throw new DeviceUnavailableException("Device is unavailable");
            }    
        }
        
        Reservation temp = new Reservation(person, devices, reservationDate, reservationEndDate);
    }
    //@todo implement functions for resolving reservation
}