using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Domain
{
    public class ApplicationUser : IdentityUser
    {
        // Common properties for Student and Instructor
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Remove Email and Password as they are already included in IdentityUser
        public DateTime DateOfBirth { get; set; }
        // Other common properties...
    }
}
