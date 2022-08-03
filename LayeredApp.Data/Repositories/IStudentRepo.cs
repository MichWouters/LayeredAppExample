using LayeredApp.Data.Entities;

namespace LayeredApp.Data.Repositories;

public interface IStudentRepo
{
    void AddStudent(Student student);

    void UpdateStudent(Student student);

    void DeleteStudent(int id);

    Student GetStudent(int id);

    IList<Student> GetAllStudents();

    IList<Student> GetAllStudentsInGroup();
}