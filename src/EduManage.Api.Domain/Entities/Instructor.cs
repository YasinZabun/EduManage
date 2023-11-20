using EduManage.Api.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Domain.Entites
{
    public class Instructor : ApplicationUser
    {
        public DateTime HireDate { get; set; }

        // Navigation property
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
    }

}
