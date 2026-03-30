using System.Runtime.CompilerServices;
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
    
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public ReservationStatus Status { get; set; }
    public DateTime ReservationDate { get; }
    public DateTime ReservationEndDate { get; }
    public float Penalty { get; private set; } = 0f;

    private Reservation(Person person, DeviceBase[] devices, DateTime reservationDate, DateTime reservationEndDate)
    {
        Owner = person;
        Owner.AddReservation(this);
        Name = person.Name;
        Surname = person.Surname;
        Owner.CurrentReservations++;
        foreach (DeviceBase device in devices)
        {
            Devices.Add(device);
            device.AddReservation(this);
            device.DeviceStatus = DeviceStatus.Unavailable;
        }
        ReservationDate = reservationDate;
        ReservationEndDate = reservationEndDate;
        Status = ReservationStatus.Ongoing;
        
        Reservations.Add(Id, this);
    }
    
    public static void CreateReservation(Person person, DeviceBase[] devices, DateTime reservationDate, DateTime reservationEndDate)
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
        
        new Reservation(person, devices, reservationDate, reservationEndDate);
    }

    public static void EndReservation(string id, DateTime returnDate)
    {
        if (!Reservations.ContainsKey(id))
        {
            throw new ReservationNotFoundException("Reservation with not found}");
        }
        
        Reservation reservation = Reservations[id];

        if (returnDate.Day > reservation.ReservationEndDate.Day)
        {
            reservation.Penalty = (reservation.ReservationEndDate - returnDate).Days * 10;
        }
        
        reservation.Owner.RemoveReservation(reservation);
        foreach (var device in reservation.Devices)
        {
            device.RemoveReservation(reservation);
            device.DeviceStatus = DeviceStatus.Available;
        }
        
        reservation.Status = ReservationStatus.Finished;
        reservation.Owner.CurrentReservations--;
    }
}