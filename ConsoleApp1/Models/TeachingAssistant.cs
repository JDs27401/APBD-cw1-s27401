using ConsoleApp1.Enums;

namespace ConsoleApp1.Models;

public class TeachingAssistant : Teacher, IStudent
{
    private string _field;
    public string Field
    {
        get => _field;
        set
        {
            IsStringValid(value);
            _field = value;
        }
    }
    public string Index { get; } = "s" + IStudent.MainId++;

    public TeachingAssistant(string name, string surname, string subject, string field) : base(name, surname, subject)
    {
        userType = UserType.TeachingAssistant;
        Field = field;
    }
}