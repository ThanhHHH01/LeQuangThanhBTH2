using System.ComponentModel.DataAnnotations;
namespace LeQuangThanhBTH2.Models
{
    public class Customer
    {
        [Key]
        public string? CusID { get; set; }
        public string? CusName { get; set; }
        public string? Address { get; set; }
    }
}