using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduManage.Api.Infrastructure.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class yasinnew1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message");

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

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                table: "Message",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ReceiverId",
                table: "Message",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43db45dd-2039-4ac5-9450-0f9783d95c6d", null, "Student", "STUDENT" },
                    { "f0f5b86d-8c9b-4d83-b36c-cb508c9950b4", null, "Admin", "ADMIN" },
                    { "fc1f4aa8-b913-4671-99d8-75a9768128fe", null, "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EnrollmentDate", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "84b3e7d6-c4ba-4cea-9bb6-3766e080767a", 0, "dc9d1db8-642f-4017-b1ce-2d22b9c10910", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "alice.johnson@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Johnson", false, null, "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "123456789aAaA.", null, false, "fb26a272-b368-4d81-b535-898efb605e29", false, "alice.johnson@example.com" },
                    { "bf04367f-1f1d-4bc3-bb2f-53c1fb20c749", 0, "1b266416-9dfb-4d40-a901-b356be56aca5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "john.doe@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "123456789aA.", null, false, "75bc4c70-5d11-443e-aa63-6d00d412da1f", false, "john.doe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f03cc239-6354-4829-bd38-b89bf14a1810", 0, "759c2d76-589a-4383-ba34-04e94ea4a525", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instructor", "jane.smith@example.com", false, "Jane", new DateTime(2023, 11, 20, 18, 28, 22, 77, DateTimeKind.Utc).AddTicks(9402), "Smith", false, null, "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "123456789aAaAaA.", null, false, "1632c30c-8aa2-41b0-ac68-0f3df06c304c", false, "jane.smith@example.com" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "Credits", "Description" },
                values: new object[,]
                {
                    { "5056c0ae-fa3b-47e2-9751-9a91d0c1b8ff", "Mathematics 101", 3, "Introductory math course" },
                    { "c0e4ba4e-2732-4f59-b3ea-c2eb448e06f0", "History 101", 4, "Introductory history course" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "43db45dd-2039-4ac5-9450-0f9783d95c6d", "84b3e7d6-c4ba-4cea-9bb6-3766e080767a" },
                    { "43db45dd-2039-4ac5-9450-0f9783d95c6d", "bf04367f-1f1d-4bc3-bb2f-53c1fb20c749" },
                    { "fc1f4aa8-b913-4671-99d8-75a9768128fe", "f03cc239-6354-4829-bd38-b89bf14a1810" }
                });

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
                    { "5056c0ae-fa3b-47e2-9751-9a91d0c1b8ff", "f03cc239-6354-4829-bd38-b89bf14a1810" },
                    { "c0e4ba4e-2732-4f59-b3ea-c2eb448e06f0", "f03cc239-6354-4829-bd38-b89bf14a1810" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { "1127dae6-73bf-4893-a665-f9834139abba", "5056c0ae-fa3b-47e2-9751-9a91d0c1b8ff", 'A', "bf04367f-1f1d-4bc3-bb2f-53c1fb20c749" },
                    { "fa3aadb7-91a9-45d5-85b1-3d8f50112e33", "c0e4ba4e-2732-4f59-b3ea-c2eb448e06f0", 'B', "84b3e7d6-c4ba-4cea-9bb6-3766e080767a" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f5b86d-8c9b-4d83-b36c-cb508c9950b4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43db45dd-2039-4ac5-9450-0f9783d95c6d", "84b3e7d6-c4ba-4cea-9bb6-3766e080767a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43db45dd-2039-4ac5-9450-0f9783d95c6d", "bf04367f-1f1d-4bc3-bb2f-53c1fb20c749" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc1f4aa8-b913-4671-99d8-75a9768128fe", "f03cc239-6354-4829-bd38-b89bf14a1810" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "5056c0ae-fa3b-47e2-9751-9a91d0c1b8ff", "f03cc239-6354-4829-bd38-b89bf14a1810" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "c0e4ba4e-2732-4f59-b3ea-c2eb448e06f0", "f03cc239-6354-4829-bd38-b89bf14a1810" });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "1127dae6-73bf-4893-a665-f9834139abba");

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "fa3aadb7-91a9-45d5-85b1-3d8f50112e33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43db45dd-2039-4ac5-9450-0f9783d95c6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1f4aa8-b913-4671-99d8-75a9768128fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84b3e7d6-c4ba-4cea-9bb6-3766e080767a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf04367f-1f1d-4bc3-bb2f-53c1fb20c749");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f03cc239-6354-4829-bd38-b89bf14a1810");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "5056c0ae-fa3b-47e2-9751-9a91d0c1b8ff");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c0e4ba4e-2732-4f59-b3ea-c2eb448e06f0");

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                table: "Message",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReceiverId",
                table: "Message",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_ReceiverId",
                table: "Message",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_SenderId",
                table: "Message",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
