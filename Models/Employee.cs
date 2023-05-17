using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HyperFoxCorp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstMidName { get; set; }
        public string LastName { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime? ExitDate { get; set; }

        public ICollection<LeaveApplication> LeaveApplications{ get; set; }

        public bool IsAdmin { get; set; }



    }
}
