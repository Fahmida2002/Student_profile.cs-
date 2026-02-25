using Microsoft.AspNetCore.Mvc;
using Student_Profile.Models;

namespace Student_Profile.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Profile()
        {
            string Department = "CSE";
            double CGPA = 3.50;

            Student_profile student = new Student_profile()
            {
                Id = 1,
                Name = "Fahmida Yasmin",
                Age = 22,
                Department = Department,
                CGPA = CGPA
            };

            return View(student);
        }
    }
}
