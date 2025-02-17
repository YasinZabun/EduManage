﻿// <auto-generated />
using System;
using EduManage.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EduManage.Api.Infrastructure.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231120092249_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EduManage.Api.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entities.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Credits")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = "375eaf85-11f1-4b36-82cf-5be3a4bf8efe",
                            CourseName = "Mathematics 101",
                            Credits = 3,
                            Description = "Introductory math course"
                        },
                        new
                        {
                            Id = "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f",
                            CourseName = "History 101",
                            Credits = 4,
                            Description = "Introductory history course"
                        });
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entities.CourseAssignment", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("text");

                    b.Property<string>("InstructorId")
                        .HasColumnType("text");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("CourseAssignments");

                    b.HasData(
                        new
                        {
                            CourseId = "375eaf85-11f1-4b36-82cf-5be3a4bf8efe",
                            InstructorId = "d0272cc7-facc-4f69-94f2-53a05d3a4d83"
                        },
                        new
                        {
                            CourseId = "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f",
                            InstructorId = "d0272cc7-facc-4f69-94f2-53a05d3a4d83"
                        });
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entities.Enrollment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char?>("Grade")
                        .HasColumnType("character(1)");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = "cd85642e-3e44-4325-bf0e-488af572bd11",
                            CourseId = "375eaf85-11f1-4b36-82cf-5be3a4bf8efe",
                            Grade = 'A',
                            StudentId = "1b9961f2-c998-4469-890a-2b4543725a9e"
                        },
                        new
                        {
                            Id = "7ef857e5-591f-43d4-80d4-24b798ff2ec2",
                            CourseId = "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f",
                            Grade = 'B',
                            StudentId = "8bd55692-014f-4548-8f98-dfae6274a50f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "161e703f-a101-47fa-8ed8-eddf140dcc79",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "757ab414-f4cd-40fe-997b-e8ff64273b27",
                            Name = "Instructor",
                            NormalizedName = "INSTRUCTOR"
                        },
                        new
                        {
                            Id = "9f16320e-319d-4425-8fea-81f4536d8b08",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1b9961f2-c998-4469-890a-2b4543725a9e",
                            RoleId = "161e703f-a101-47fa-8ed8-eddf140dcc79"
                        },
                        new
                        {
                            UserId = "8bd55692-014f-4548-8f98-dfae6274a50f",
                            RoleId = "161e703f-a101-47fa-8ed8-eddf140dcc79"
                        },
                        new
                        {
                            UserId = "d0272cc7-facc-4f69-94f2-53a05d3a4d83",
                            RoleId = "757ab414-f4cd-40fe-997b-e8ff64273b27"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entites.Instructor", b =>
                {
                    b.HasBaseType("EduManage.Api.Domain.ApplicationUser");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasDiscriminator().HasValue("Instructor");

                    b.HasData(
                        new
                        {
                            Id = "d0272cc7-facc-4f69-94f2-53a05d3a4d83",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1ffdeb38-31a8-48c4-946d-b614551dc172",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@example.com",
                            EmailConfirmed = false,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
                            NormalizedUserName = "JANE.SMITH@EXAMPLE.COM",
                            PasswordHash = "123456789aAaAaA.",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d0ec5b4a-4f07-4c9a-aabe-cbc69b1bcb80",
                            TwoFactorEnabled = false,
                            UserName = "jane.smith@example.com",
                            HireDate = new DateTime(2023, 11, 20, 9, 22, 49, 637, DateTimeKind.Utc).AddTicks(5724)
                        });
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entites.Student", b =>
                {
                    b.HasBaseType("EduManage.Api.Domain.ApplicationUser");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            Id = "1b9961f2-c998-4469-890a-2b4543725a9e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "47823b08-ad00-4ee5-b155-358587728d42",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                            NormalizedUserName = "JOHN.DOE@EXAMPLE.COM",
                            PasswordHash = "123456789aA.",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b8040510-a456-45e1-b6ca-dc3e899dc137",
                            TwoFactorEnabled = false,
                            UserName = "john.doe@example.com",
                            EnrollmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "8bd55692-014f-4548-8f98-dfae6274a50f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e44a2de1-0044-4147-8422-0a51d8760161",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice.johnson@example.com",
                            EmailConfirmed = false,
                            FirstName = "Alice",
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALICE.JOHNSON@EXAMPLE.COM",
                            NormalizedUserName = "ALICE.JOHNSON@EXAMPLE.COM",
                            PasswordHash = "123456789aAaA.",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6a99a95f-9d6a-4ab2-be84-c8017599769b",
                            TwoFactorEnabled = false,
                            UserName = "alice.johnson@example.com",
                            EnrollmentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entities.CourseAssignment", b =>
                {
                    b.HasOne("EduManage.Api.Domain.Entities.Course", "Course")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduManage.Api.Domain.Entites.Instructor", "Instructor")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("EduManage.Api.Domain.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduManage.Api.Domain.Entites.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EduManage.Api.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EduManage.Api.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduManage.Api.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EduManage.Api.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entities.Course", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entites.Instructor", b =>
                {
                    b.Navigation("CourseAssignments");
                });

            modelBuilder.Entity("EduManage.Api.Domain.Entites.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
