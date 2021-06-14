using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class LeaveType
    {
        [Key]    //primary key required mentioned
        public int Id { get; set; }
        [Required] //not null field mentioned
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
