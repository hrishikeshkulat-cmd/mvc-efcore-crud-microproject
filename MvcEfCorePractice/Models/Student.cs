using System.ComponentModel.DataAnnotations;

namespace MvcEfCorePractice.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="name is required")]
        public string Name { get; set; }

        public double Age { get; set; }

    }
}
