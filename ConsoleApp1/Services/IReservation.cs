namespace ConsoleApp1.Services;

public interface IReservation
{
    void AddReservation(Reservation reservation);
    void RemoveReservation(Reservation reservation);
}