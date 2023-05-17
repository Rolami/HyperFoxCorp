using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperFoxCorp.Models
{
    public class LeaveApplication
    {
        
        [Key]
        public int LeaveApplicationId { get; set; }

        [ForeignKey("Employee")]
        public int FK_EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public DateTime LeaveDate { get; set; }

        public DateTime ReturnDate { get; set; }


        [MaxLength(240)] //longtweet
        public string LeaveType { get; set; }
        public DateTime ApplicationDate { get; set; }

        public enum ApplicationStatus
        {
            Recieved, Evaluating, Approved, Denied
        }

    }
}

