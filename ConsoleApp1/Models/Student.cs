using ConsoleApp1.Enums;

namespace ConsoleApp1.Models;

public class Student : Person, IStudent
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
    public string Index {get; } = "s" + IStudent.MainId++;
    
    public Student(string name, string surname, string field) : base(name, surname, 2)
    {
        userType = UserType.Student;
        Field = field;
    }
}