namespace ConsoleApp1.Models;

public abstract class Person
{
    private static int _mainId = 1;
    public int Id { get; } = _mainId++;

    private int _currentResercation;
    public int CurrentReservation
    {
        get => _currentResercation;
        private set
        {
            _currentResercation = value;
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

    public Person(string name, string surname, int maxReservations)
    {
        Name = name;
        Surname = surname;
        MaxReservations = maxReservations;
    }

    protected void IsStringValid(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            throw new ArgumentNullException();
        }
    }
}