using EduManage.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Application.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetCoursesForStudentAsync(string studentId);
        Task<IEnumerable<Course>> GetCoursesForInstructorAsync(string instructorId);
    }

}
