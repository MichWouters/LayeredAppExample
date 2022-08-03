using LayeredApp.Data.Entities;

namespace LayeredApp.Data.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        public void AddStudent(Student student)
        {
            // ...
        }

        public void UpdateStudent(Student student)
        {
            // ...
        }

        public void DeleteStudent(int id)
        {
            // ...
        }

        public Student GetStudent(int id)
        {
            return null;
        }

        public IList<Student> GetAllStudents()
        {
            return null;
        }

        public IList<Student> GetAllStudentsInGroup()
        {
            return null;
        }
    }
}