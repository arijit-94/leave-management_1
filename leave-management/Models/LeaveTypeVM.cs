using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        //public int Id { get; set; }
        [Required]
        public string Name { get; set; }  //Name field required (for validation purpose)
        //public DateTime DateCreated { get; set; } At the time of creation we dont need the date
    }
}
