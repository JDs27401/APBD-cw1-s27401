using ConsoleApp1.Models;

namespace ConsoleApp1.Services;

public class RaportGenerator
{
    public static void GenerateRaport()
    {
        ICollection<Person> persons = Person.Persons;
        ICollection<DeviceBase> devices = DeviceBase.Devices;
        Dictionary<string, Reservation> reservations = Reservation.Reservations;
        
        string raport = "Reservations:\n";

        foreach (var reservation in reservations)
        {
            raport += reservation.Key + '\t' + reservation.Value.Status + '\t' + reservation.Value.Name + '\t' + reservation.Value.Surname + '\t';
            foreach (var id in reservation.Value.DeviceIds)
            {
                raport += id + '\t';
            }
            raport += "\n";
        }
        
        raport += "Devices:\n";
        foreach (var device in devices)
        {
            raport += device.Id + '\t' + device.Name + '\t' + device.DeviceStatus + '\n';
        }
        
        raport += "People:\n";
        foreach (var person in persons)
        {
            raport += person.Id.ToString() + '\t' + person.userType + '\t' + person.Name + '\t' + person.Surname + '\n';
        }
        
        Console.WriteLine(raport);
    }
}