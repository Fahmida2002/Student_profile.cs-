using System.ComponentModel.DataAnnotations;
namespace Student_Profile.Models 
{
    public class Student_profile 
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Department { get; set; } = string.Empty;

        public double CGPA { get; set; }
    }
}
