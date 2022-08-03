using LayeredApp.Data.Entities;
using LayeredApp.Data.Repositories;
using LayeredAppExample.Services;
using Moq;

namespace LayeredAppExample.Business.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetStudent_ShouldReturnStudent_WithID9999()
        {
            // Arrange
            Mock<IStudentRepo> _repoMock = new Mock<IStudentRepo>();
            _repoMock
                .Setup(x => x.GetStudent(1))
                .Returns(new Student
                {
                    Age = 24,
                    FirstName = "Ken",
                    LastName = "Field",
                });
            IStudentService studentService = new StudentService(_repoMock.Object);

            // Act
            var result = studentService.DoSomethingWithStudent();

            // Assert
            Assert.AreEqual(9999, result.Id);
        }




        //[TestCase(5,7,12)]
        //[TestCase(24, 33, 57)]
        //[TestCase(1, 1, 2)]
        //public void AddNumbers_ShouldReturn_SumOfNumbers(int number1, int number2, int expected)
        //{
        //    // Arrange
        //    IStudentService service = new StudentService();

        //    // Act 
        //    int result =  service.AddNumber(number1, number2);

        //    // Assert
        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //public void Subtract_ShouldReturn_SumOfNumbers()
        //{
        //    // Arrange
        //    IStudentService service = new StudentService();
        //    int number = 7;
        //    int number2 = 5;

        //    // Act 
        //    int result = service.SubtractNumber(number, number2);

        //    // Assert
        //    Assert.AreEqual(2, result);
        //}

        //[Test]
        //public void Foo()
        //{

        //}
    }
}