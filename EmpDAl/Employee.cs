using System.ComponentModel.DataAnnotations;

namespace EmpDAl
{
    public class Employee
    {
       
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }    
        public string Gender {  get; set; }
        public string BloodGroup{ get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

    }
}
