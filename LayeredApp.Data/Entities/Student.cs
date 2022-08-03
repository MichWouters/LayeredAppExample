using System.ComponentModel.DataAnnotations;

namespace LayeredApp.Data.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Range(12, 20)]
        public int Age { get; set; }

        [Required]
        public int GroupId { get; set; }

        public Group Group { get; set; }
    }
}