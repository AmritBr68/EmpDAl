using System.ComponentModel.DataAnnotations;

namespace EmpPresentation.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string EmpName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        [StringLength(10)]
        public string ContactNumber { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
