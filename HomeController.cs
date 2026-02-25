using Microsoft.AspNetCore.Mvc;
using Student_Profile.Models;
using System.Collections.Generic;

namespace Student_Profile.Controllers
{
    public class HomeController : Controller
    {
        // Student List Page
        public IActionResult Index()
        {
            List<Student_profile> students = new List<Student_profile>()
            {
                new Student_profile{ Id=1, Name="Fahmida Yasmin", Age=22, Department="CSE", CGPA=3.50 },
                new Student_profile{ Id=2, Name="Nusrat", Age=23, Department="EEE", CGPA=3.80 }
            };

            return View(students);
        }

        // Single Student Profile Page
        public IActionResult Profile(int id)
        {
            Student_profile student = new Student_profile()
            {
                Id = id,
                Name = "Fahmida Yasmin",
                Age = 22,
                Department = "CSE",
                CGPA = 3.50
            };

            return View(student);
        }
    }
}
