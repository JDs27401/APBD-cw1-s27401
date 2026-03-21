namespace ConsoleApp1.Models;

public abstract class Person(string name, string surname, int maxReservations)
{
    private static int _mainId = 1;

    public int Id { get; } =_mainId++;
    public int CurrentReservation { get; set; }
    public int MaxReservations { get; private set; } = maxReservations;
    public string Name { get; set; } = name;
    public string Surname { get; set; } = surname;
}