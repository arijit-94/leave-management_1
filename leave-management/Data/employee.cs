using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class employee : IdentityUser // IdentityUser table represents the AspNetUsers
                                         // table so we have to inherit
    {
        //Adding properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
