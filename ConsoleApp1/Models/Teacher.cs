namespace ConsoleApp1.Models;

public class Teacher : Person
{
    private string _subject;
    public string Subject
    {
        get => _subject;
        set
        {
            IsStringValid(value);
            _subject = value;
        }
    }

    public Teacher(string name, string surname, string subject) : base(name, surname, 5)
    {
        Subject = subject;
    }
}