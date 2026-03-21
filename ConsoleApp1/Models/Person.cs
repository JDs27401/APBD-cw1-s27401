namespace ConsoleApp1.Models;

public abstract class Person(string name, string surname, int maxReservations)
{
    private static int _mainId = 1;

    public int MaxReservations { get; private set; } = maxReservations;
    public int Id { get; } =_mainId++;
    public string Name { get; set; } = name;
    public string Surname { get; set; } = surname;
}