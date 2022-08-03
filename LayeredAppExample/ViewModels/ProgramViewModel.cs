using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredApp.Data.Entities;
using LayeredAppExample.Models;
using LayeredAppExample.Services;

namespace LayeredAppExample.ViewModels
{
    public class ProgramViewModel
    {
        private IStudentService _service;

        public StudentModel HonourStudent { get; set; }

        public ProgramViewModel(IStudentService service)
        {
            _service = service;
        }


        public StudentModel DisplayHonourStudent()
        {
            HonourStudent=  _service.DoSomethingWithStudent();

            return HonourStudent;
        }

    }
}
