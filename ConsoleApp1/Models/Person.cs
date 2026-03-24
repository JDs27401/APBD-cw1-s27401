using ConsoleApp1.Services;

namespace ConsoleApp1.Models;

public abstract class Person : IReservation
{
    public ICollection<Person> Persons { get; } = new List<Person>();
    
    private static int _mainId = 1;
    public int Id { get; } = _mainId++;
    
    private ICollection<Reservation> _reservations = new List<Reservation>();

    private int _currentReservations;
    public int CurrentReservations
    {
        get => _currentReservations;
        private set
        {
            _currentReservations = value;
        }
    }

    private int _maxReservations;

    public int MaxReservations
    {
        get => _maxReservations;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(MaxReservations), "Max reservations must be greater than zero");
            }
            _maxReservations = value;
        }
    }
    
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            IsStringValid(value);
            _name = value;
        }
    }

    private string _surname;

    public string Surname
    {
        get => _surname;
        set
        {
            IsStringValid(value);
            _surname = value;
        }
    }

    protected Person(string name, string surname, int maxReservations)
    {
        Name = name;
        Surname = surname;
        MaxReservations = maxReservations;
        Persons.Add(this);
    }

    public void AddReservation(Reservation reservation)
    {
        _reservations.Add(reservation);
    }

    public void RemoveReservation(Reservation reservation)
    {
        _reservations.Remove(reservation);
    }

    protected void IsStringValid(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            throw new ArgumentNullException();
        }
    }
}