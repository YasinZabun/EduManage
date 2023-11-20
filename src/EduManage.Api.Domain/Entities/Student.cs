using EduManage.Api.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Domain.Entites
{
    public class Student : ApplicationUser
    {
        public DateTime DateOfBirth { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation property for relationships
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
    }
}
