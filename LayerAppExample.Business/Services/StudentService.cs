using LayeredApp.Data.Entities;
using LayeredApp.Data.Repositories;
using LayeredAppExample.Models;

namespace LayeredAppExample.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepo _repo;

        public StudentService(IStudentRepo repo)
        {
            _repo = repo;
        }

        public StudentModel DoSomethingWithStudent()
        {
            Student student = _repo.GetStudent(1);

            StudentModel studentModel = new StudentModel
            {
                Age = student.Age,
                Group = student.Group.Name,
                Name = $"{student.FirstName} {student.LastName}",
                Id = student.Id,
                GroupId = student.GroupId
            };

            studentModel.Id = 9999;

            return studentModel;
        }

        public int AddNumber(int number1, int number2)
        {
            return number1 + number2;
        }

        public int SubtractNumber(int number, int number2)
        {
            return number - number2;
        }
    }
}