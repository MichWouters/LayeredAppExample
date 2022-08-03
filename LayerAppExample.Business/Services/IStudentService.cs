using LayeredAppExample.Models;

namespace LayeredAppExample.Services;

public interface IStudentService
{
    StudentModel DoSomethingWithStudent();

    int AddNumber(int number1, int number2);
    int SubtractNumber(int number, int number2);
}