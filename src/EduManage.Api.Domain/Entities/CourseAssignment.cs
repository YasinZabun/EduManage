using EduManage.Api.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Domain.Entities
{
    public class CourseAssignment
    {
        public string InstructorId { get; set; }
        public string CourseId { get; set; }

        // Navigation properties
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }

}
