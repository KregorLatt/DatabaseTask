using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Project
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Task { get; set; }
        public DateTime DeadLine { get; set; }
        
        public string NumberOfEmployees { get; set; }
        
    }
}
