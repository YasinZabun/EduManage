using EduManage.Api.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    // GET: api/courses/student/5
    [HttpGet("student/{studentId}")]
    [Authorize(Roles = "Student,Admin")]
    public async Task<IActionResult> GetCoursesForStudent(string studentId)
    {
        try
        {
            var courses = await _courseService.GetCoursesForStudentAsync(studentId);
            if (courses == null || !courses.Any())
            {
                return NotFound("Courses not found for the given student.");
            }

            return Ok(courses);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }

    // GET: api/courses/instructor/5
    [HttpGet("instructor/{instructorId}")]
    [Authorize(Roles = "Instructor,Admin")]
    public async Task<IActionResult> GetCoursesForInstructor(string instructorId)
    {
        try
        {
            var courses = await _courseService.GetCoursesForInstructorAsync(instructorId);
            if (courses == null || !courses.Any())
            {
                return NotFound("Courses not found for the given instructor.");
            }

            return Ok(courses);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }

    // Other controller actions...
}
