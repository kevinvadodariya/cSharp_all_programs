using System.ComponentModel.DataAnnotations;

namespace CodeFirstApiCRUD.Models
{
    public class Employee
    {
        [Key]
        public int  emp_id { get; set; }
        [Required]
        public String EmployeeName { get; set; } = null!;
        public int Age { get; set; }
        public String Gender { get; set; } = null!;
    }
}
