using System.ComponentModel.DataAnnotations;

namespace LayeredApp.Data.Entities
{
    public class Group
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Teacher { get; set; }

        public IList<Student> Students { get; set; }
    }
}