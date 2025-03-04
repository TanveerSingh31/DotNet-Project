using System.ComponentModel.DataAnnotations;

namespace first_project.Models
{
    // table model
	public class Student
	{
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}

