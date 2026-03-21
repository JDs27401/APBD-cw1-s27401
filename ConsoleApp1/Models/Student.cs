namespace ConsoleApp1.Models;

public class Student(string name, string surname, string field) : Person(name, surname, 2), IStudent
{
    private string _field = field;
    public string Field
    {
        get => _field;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(Field), "Field cannot be null or empty");
            }
            _field = value;
        }
    }
    public string Index {get; } = "s" + IStudent.MainId++;
}