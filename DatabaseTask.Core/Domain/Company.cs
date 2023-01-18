using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        //public Project ProjectId { get; set; }
        
        //public Specialist SpecialistId { get; set; }

    }
}
