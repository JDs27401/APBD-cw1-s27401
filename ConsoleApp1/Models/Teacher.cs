namespace ConsoleApp1.Models;

public class Teacher(string name, string surname, string subject) : Person(name, surname, 5)
{
    private string _subject = subject;

    public string Subject
    {
        get => _subject;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(Subject), "Subject cannot be null or empty");
            }
            _subject = value;
        }
    }
}