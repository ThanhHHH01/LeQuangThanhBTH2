using System.ComponentModel.DataAnnotations;

namespace LeQuangThanhBTH2.Models
{
    public class Faculty
    {
    [Key]
    public string FacultyID { get; set; }
    public string FacultyName { get; set; }
    }
}