using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Specialist
    {
        [Key]
        public int Id { get; set; }
        
        public EmployeeOps EmployeeId { get; set; }
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        
        //public Project ProjectId { get; set; }
    }
}
