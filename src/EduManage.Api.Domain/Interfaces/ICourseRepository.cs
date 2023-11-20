using EduManage.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Domain.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        Task<IEnumerable<Course>> GetByStudentIdAsync(string id);
        Task<IEnumerable<Course>> GetByInstructorIdAsync(string id);
    }
}
