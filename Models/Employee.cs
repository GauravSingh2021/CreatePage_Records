using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMP.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required(ErrorMessage ="* Enter your Name")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "* Enter your Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "* Enter your City")]
        public string City { get; set; }
        [Required(ErrorMessage = "* Enter your Salary")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "* Enter your MobileNo")]
        public string MobileNo { get; set; }
    }
}
