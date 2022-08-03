// See https://aka.ms/new-console-template for more information

using LayeredApp.Data.Repositories;
using LayeredAppExample.Services;
using LayeredAppExample.ViewModels;

Console.WriteLine("Hello, World!");

// DI
IStudentRepo studentRepo =new StudentRepo();
IStudentService studentService = new StudentService(studentRepo);
ProgramViewModel vm = new ProgramViewModel(studentService);


var student = vm.DisplayHonourStudent();
Console.WriteLine($"This year's top student was: {student.Name }");