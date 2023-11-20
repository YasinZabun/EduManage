using EduManage.Api.Domain.Entites;
using EduManage.Api.Domain.Entities;
using EduManage.Api.Domain.Interfaces;
using EduManage.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Course>> GetByInstructorIdAsync(string id)
        {
            return await _context.CourseAssignments
                             .Where(e => e.InstructorId == id)
                             .Select(e => e.Course)
                             .ToListAsync();
        }

        public async Task<IEnumerable<Course>> GetByStudentIdAsync(string id)
        {
            return await _context.Enrollments
                             .Where(e => e.StudentId == id)
                             .Select(e => e.Course)
                             .ToListAsync();
        }
        public Task AddAsync(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }


        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
