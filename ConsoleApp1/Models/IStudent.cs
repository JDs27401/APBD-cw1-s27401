namespace ConsoleApp1.Models;

public interface IStudent
{
    static int MainId = 1;
    string Field { get; set; }
    string Index {get; }
}