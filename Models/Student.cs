using System.ComponentModel.DataAnnotations;
namespace LeQuangThanhBTH2.Models
{
    public class Student
    {
        [Key]
        public string? StdID { get; set; }
        public string? StdName { get; set; }
        public string? Address { get; set; }
    }
}