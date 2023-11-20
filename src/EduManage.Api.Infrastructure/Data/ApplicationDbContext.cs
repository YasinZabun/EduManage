using EduManage.Api.Domain;
using EduManage.Api.Domain.Entites;
using EduManage.Api.Domain.Entities;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EduManage.Api.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Student-Enrollment relationship
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.Id);

            // Course-Enrollment relationship
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Enrollments)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId);

            // Instructor-CourseAssignment relationship
            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.CourseAssignments)
                .WithOne(ca => ca.Instructor)
                .HasForeignKey(ca => ca.InstructorId);

            // Course-CourseAssignment relationship
            modelBuilder.Entity<Course>()
                .HasMany(c => c.CourseAssignments)
                .WithOne(ca => ca.Course)
                .HasForeignKey(ca => ca.CourseId);

            modelBuilder.Entity<CourseAssignment>()
                .HasKey(ca => new { ca.CourseId, ca.InstructorId });

            modelBuilder.Entity<CourseAssignment>()
                .HasOne(ca => ca.Instructor)
                .WithMany(i => i.CourseAssignments)
                .HasForeignKey(ca => ca.InstructorId);

            modelBuilder.Entity<CourseAssignment>()
                .HasOne(ca => ca.Course)
                .WithMany(c => c.CourseAssignments)
                .HasForeignKey(ca => ca.CourseId);


            modelBuilder.Entity<Enrollment>()
               .HasOne(e => e.Student)
               .WithMany(s => s.Enrollments)
               .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            // Configure Message entity
            modelBuilder.Entity<Message>()
                .HasKey(m => m.MessageId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.SenderStudent)
                .WithMany(s => s.SentMessages)
                .HasForeignKey(m => m.SenderId)
                .IsRequired(false);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.SenderInstructor)
                .WithMany(i => i.SentMessages)
                .HasForeignKey(m => m.SenderId)
                .IsRequired(false);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.ReceiverStudent)
                .WithMany(s => s.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .IsRequired(false);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.ReceiverInstructor)
                .WithMany(i => i.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .IsRequired(false);
            
            // Seed Roles
            var studentRoleId = Guid.NewGuid().ToString();
            var instructorRoleId = Guid.NewGuid().ToString();
            var adminRoleId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = studentRoleId, Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole { Id = instructorRoleId, Name = "Instructor", NormalizedName = "INSTRUCTOR" },
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" }
            );

            // Seed Users (Students and Instructors)
            var student1Id = Guid.NewGuid().ToString();
            var student2Id = Guid.NewGuid().ToString();
            var instructor1Id = Guid.NewGuid().ToString();

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = student1Id, UserName = "john.doe@example.com", Email = "john.doe@example.com", NormalizedEmail = "JOHN.DOE@EXAMPLE.COM", NormalizedUserName = "JOHN.DOE@EXAMPLE.COM", PasswordHash = "123456789aA.", FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), SecurityStamp = Guid.NewGuid().ToString() },
                new Student { Id = student2Id, UserName = "alice.johnson@example.com", Email = "alice.johnson@example.com", NormalizedEmail = "ALICE.JOHNSON@EXAMPLE.COM", NormalizedUserName = "ALICE.JOHNSON@EXAMPLE.COM", PasswordHash = "123456789aAaA.", FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(2001, 2, 2, 0, 0, 0, DateTimeKind.Utc), SecurityStamp = Guid.NewGuid().ToString() }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { Id = instructor1Id, UserName = "jane.smith@example.com", Email = "jane.smith@example.com", NormalizedEmail = "JANE.SMITH@EXAMPLE.COM", NormalizedUserName = "JANE.SMITH@EXAMPLE.COM", PasswordHash = "123456789aAaAaA.", FirstName = "Jane", LastName = "Smith", HireDate = DateTime.UtcNow, SecurityStamp = Guid.NewGuid().ToString() }
            );

            // Seed UserRoles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = student1Id, RoleId = studentRoleId },
                new IdentityUserRole<string> { UserId = student2Id, RoleId = studentRoleId },
                new IdentityUserRole<string> { UserId = instructor1Id, RoleId = instructorRoleId }
            );

            // Seed Courses
            var courseId1 = Guid.NewGuid().ToString();
            var courseId2 = Guid.NewGuid().ToString();

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = courseId1, CourseName = "Mathematics 101", Description = "Introductory math course", Credits = 3 },
                new Course { Id = courseId2, CourseName = "History 101", Description = "Introductory history course", Credits = 4 }
            );

            // Seed Enrollments
            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { Id = Guid.NewGuid().ToString(), CourseId = courseId1, StudentId = student1Id, Grade = 'A' },
                new Enrollment { Id = Guid.NewGuid().ToString(), CourseId = courseId2, StudentId = student2Id, Grade = 'B' }
            );

            // Seed CourseAssignments
            modelBuilder.Entity<CourseAssignment>().HasData(
                new CourseAssignment { CourseId = courseId1, InstructorId = instructor1Id },
                new CourseAssignment { CourseId = courseId2, InstructorId = instructor1Id }
            );

        }
    }
}
