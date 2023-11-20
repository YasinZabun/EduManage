using EduManage.Api.Application.Interfaces;
using EduManage.Api.Domain.Entites;
using EduManage.Api.Domain.Entities;
using EduManage.Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Course>> GetCoursesForStudentAsync(string studentId)
        {
            return await _courseRepository.GetByStudentIdAsync(studentId);
        }

        public async Task<IEnumerable<Course>> GetCoursesForInstructorAsync(string instructorId)
        {
            return await _courseRepository.GetByInstructorIdAsync(instructorId);
        }
    }

}
