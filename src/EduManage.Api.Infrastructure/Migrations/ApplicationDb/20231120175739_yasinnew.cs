using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduManage.Api.Infrastructure.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class yasinnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f16320e-319d-4425-8fea-81f4536d8b08");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "161e703f-a101-47fa-8ed8-eddf140dcc79", "1b9961f2-c998-4469-890a-2b4543725a9e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "161e703f-a101-47fa-8ed8-eddf140dcc79", "8bd55692-014f-4548-8f98-dfae6274a50f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "757ab414-f4cd-40fe-997b-e8ff64273b27", "d0272cc7-facc-4f69-94f2-53a05d3a4d83" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "375eaf85-11f1-4b36-82cf-5be3a4bf8efe", "d0272cc7-facc-4f69-94f2-53a05d3a4d83" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f", "d0272cc7-facc-4f69-94f2-53a05d3a4d83" });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "7ef857e5-591f-43d4-80d4-24b798ff2ec2");

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "cd85642e-3e44-4325-bf0e-488af572bd11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "161e703f-a101-47fa-8ed8-eddf140dcc79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "757ab414-f4cd-40fe-997b-e8ff64273b27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b9961f2-c998-4469-890a-2b4543725a9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bd55692-014f-4548-8f98-dfae6274a50f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0272cc7-facc-4f69-94f2-53a05d3a4d83");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "375eaf85-11f1-4b36-82cf-5be3a4bf8efe");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<string>(type: "text", nullable: false),
                    MessageText = table.Column<string>(type: "text", nullable: false),
                    SenderId = table.Column<string>(type: "text", nullable: false),
                    SenderType = table.Column<int>(type: "integer", nullable: false),
                    ReceiverId = table.Column<string>(type: "text", nullable: false),
                    ReceiverType = table.Column<int>(type: "integer", nullable: false),
                    BaseConversationId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Message_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11f10f0a-5801-412a-884c-c5f52fa45b36", null, "Student", "STUDENT" },
                    { "c3e2905e-fba0-4c40-99dc-26b2bff82d7b", null, "Admin", "ADMIN" },
                    { "fc045164-1326-4889-9c23-784e3b090e9f", null, "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69f17e39-3a83-4dee-af50-e9509a73981a", 0, "15d7cd3d-8a74-4347-8054-67b2b871350f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instructor", "jane.smith@example.com", false, "Jane", new DateTime(2023, 11, 20, 17, 57, 39, 520, DateTimeKind.Utc).AddTicks(1780), "Smith", false, null, "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "123456789aAaAaA.", null, false, "b1d3aa83-dbb8-4429-b0b5-f048086880ae", false, "jane.smith@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EnrollmentDate", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8f257ec3-bf86-415b-ae53-e7dc56008f0c", 0, "fff27e3c-d568-43b6-8bd9-4e2d744b2357", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "john.doe@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "123456789aA.", null, false, "8b16ce7f-4c09-4cbe-aae0-df3bf2d09d50", false, "john.doe@example.com" },
                    { "ca426b97-ab32-4206-a9c4-90a06aeb68ed", 0, "1472f19e-9d7f-424a-b90e-c0cba8b8536d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "alice.johnson@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Johnson", false, null, "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "123456789aAaA.", null, false, "f64d3255-ec1e-402b-9ee4-6b90d4e4605d", false, "alice.johnson@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "Credits", "Description" },
                values: new object[,]
                {
                    { "e432a8aa-491e-4e13-8a0f-d51050de77f1", "Mathematics 101", 3, "Introductory math course" },
                    { "f8d85dd1-a288-4e7a-bc30-3e10f3ffcef5", "History 101", 4, "Introductory history course" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fc045164-1326-4889-9c23-784e3b090e9f", "69f17e39-3a83-4dee-af50-e9509a73981a" },
                    { "11f10f0a-5801-412a-884c-c5f52fa45b36", "8f257ec3-bf86-415b-ae53-e7dc56008f0c" },
                    { "11f10f0a-5801-412a-884c-c5f52fa45b36", "ca426b97-ab32-4206-a9c4-90a06aeb68ed" }
                });

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
                    { "e432a8aa-491e-4e13-8a0f-d51050de77f1", "69f17e39-3a83-4dee-af50-e9509a73981a" },
                    { "f8d85dd1-a288-4e7a-bc30-3e10f3ffcef5", "69f17e39-3a83-4dee-af50-e9509a73981a" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { "46a63437-c6ec-43c7-9aad-7540793e24cb", "f8d85dd1-a288-4e7a-bc30-3e10f3ffcef5", 'B', "ca426b97-ab32-4206-a9c4-90a06aeb68ed" },
                    { "b10c3562-8f55-45a1-9464-48ad146e12dc", "e432a8aa-491e-4e13-8a0f-d51050de77f1", 'A', "8f257ec3-bf86-415b-ae53-e7dc56008f0c" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message_ReceiverId",
                table: "Message",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e2905e-fba0-4c40-99dc-26b2bff82d7b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc045164-1326-4889-9c23-784e3b090e9f", "69f17e39-3a83-4dee-af50-e9509a73981a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11f10f0a-5801-412a-884c-c5f52fa45b36", "8f257ec3-bf86-415b-ae53-e7dc56008f0c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11f10f0a-5801-412a-884c-c5f52fa45b36", "ca426b97-ab32-4206-a9c4-90a06aeb68ed" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "e432a8aa-491e-4e13-8a0f-d51050de77f1", "69f17e39-3a83-4dee-af50-e9509a73981a" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "f8d85dd1-a288-4e7a-bc30-3e10f3ffcef5", "69f17e39-3a83-4dee-af50-e9509a73981a" });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "46a63437-c6ec-43c7-9aad-7540793e24cb");

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "b10c3562-8f55-45a1-9464-48ad146e12dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11f10f0a-5801-412a-884c-c5f52fa45b36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc045164-1326-4889-9c23-784e3b090e9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69f17e39-3a83-4dee-af50-e9509a73981a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f257ec3-bf86-415b-ae53-e7dc56008f0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca426b97-ab32-4206-a9c4-90a06aeb68ed");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "e432a8aa-491e-4e13-8a0f-d51050de77f1");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f8d85dd1-a288-4e7a-bc30-3e10f3ffcef5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "161e703f-a101-47fa-8ed8-eddf140dcc79", null, "Student", "STUDENT" },
                    { "757ab414-f4cd-40fe-997b-e8ff64273b27", null, "Instructor", "INSTRUCTOR" },
                    { "9f16320e-319d-4425-8fea-81f4536d8b08", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EnrollmentDate", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b9961f2-c998-4469-890a-2b4543725a9e", 0, "47823b08-ad00-4ee5-b155-358587728d42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "john.doe@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "123456789aA.", null, false, "b8040510-a456-45e1-b6ca-dc3e899dc137", false, "john.doe@example.com" },
                    { "8bd55692-014f-4548-8f98-dfae6274a50f", 0, "e44a2de1-0044-4147-8422-0a51d8760161", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "alice.johnson@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Johnson", false, null, "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "123456789aAaA.", null, false, "6a99a95f-9d6a-4ab2-be84-c8017599769b", false, "alice.johnson@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0272cc7-facc-4f69-94f2-53a05d3a4d83", 0, "1ffdeb38-31a8-48c4-946d-b614551dc172", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instructor", "jane.smith@example.com", false, "Jane", new DateTime(2023, 11, 20, 9, 22, 49, 637, DateTimeKind.Utc).AddTicks(5724), "Smith", false, null, "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "123456789aAaAaA.", null, false, "d0ec5b4a-4f07-4c9a-aabe-cbc69b1bcb80", false, "jane.smith@example.com" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "Credits", "Description" },
                values: new object[,]
                {
                    { "375eaf85-11f1-4b36-82cf-5be3a4bf8efe", "Mathematics 101", 3, "Introductory math course" },
                    { "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f", "History 101", 4, "Introductory history course" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "161e703f-a101-47fa-8ed8-eddf140dcc79", "1b9961f2-c998-4469-890a-2b4543725a9e" },
                    { "161e703f-a101-47fa-8ed8-eddf140dcc79", "8bd55692-014f-4548-8f98-dfae6274a50f" },
                    { "757ab414-f4cd-40fe-997b-e8ff64273b27", "d0272cc7-facc-4f69-94f2-53a05d3a4d83" }
                });

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
                    { "375eaf85-11f1-4b36-82cf-5be3a4bf8efe", "d0272cc7-facc-4f69-94f2-53a05d3a4d83" },
                    { "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f", "d0272cc7-facc-4f69-94f2-53a05d3a4d83" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { "7ef857e5-591f-43d4-80d4-24b798ff2ec2", "60f254e2-ceb8-4d43-adc3-a7cfb52e7f2f", 'B', "8bd55692-014f-4548-8f98-dfae6274a50f" },
                    { "cd85642e-3e44-4325-bf0e-488af572bd11", "375eaf85-11f1-4b36-82cf-5be3a4bf8efe", 'A', "1b9961f2-c998-4469-890a-2b4543725a9e" }
                });
        }
    }
}
