using EduManage.Api.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Domain.Entities
{
    public class Enrollment
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public char? Grade { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}
