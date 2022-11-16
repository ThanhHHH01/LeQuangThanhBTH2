using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeQuangThanhBTH2.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentdName { get; set; }
        public string FacultyID{ get; set; }
        [ForeignKey("FacultyID")]
        public Faculty Faculty { get; set; }
    }
}