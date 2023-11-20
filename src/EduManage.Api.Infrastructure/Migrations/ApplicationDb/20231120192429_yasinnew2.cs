using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduManage.Api.Infrastructure.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class yasinnew2 : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
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

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameIndex(
                name: "IX_Message_SenderId",
                table: "Messages",
                newName: "IX_Messages_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ReceiverId",
                table: "Messages",
                newName: "IX_Messages_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "MessageId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c3ed849-49a5-430d-b264-cf283054b935", null, "Instructor", "INSTRUCTOR" },
                    { "af45ff5c-c086-4e35-8633-64ba94aef8bf", null, "Admin", "ADMIN" },
                    { "d5e2829f-a08d-4866-a917-67d293d2bc56", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EnrollmentDate", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11d175ac-391e-4ed0-bd92-a325e91e7eae", 0, "a7f393f2-76c9-431a-aa5c-f8a08f96c527", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "alice.johnson@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Johnson", false, null, "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "123456789aAaA.", null, false, "939635ac-a08d-4cbd-b460-b8e68932e04c", false, "alice.johnson@example.com" },
                    { "568855ee-f08d-4313-aeb4-c3ed5033a9d5", 0, "e5092117-59f3-44db-8aee-2fa66fc05a9a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "john.doe@example.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "123456789aA.", null, false, "ba071bbf-2534-4956-98b0-072b244a9a56", false, "john.doe@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8b009732-ba8f-407b-9755-d8a10f36c043", 0, "dd17a58a-560a-407b-9dbd-af010c31be5c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instructor", "jane.smith@example.com", false, "Jane", new DateTime(2023, 11, 20, 19, 24, 29, 414, DateTimeKind.Utc).AddTicks(3895), "Smith", false, null, "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", "123456789aAaAaA.", null, false, "1cd48ea9-f567-4a91-83f9-d0225271fbe7", false, "jane.smith@example.com" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "Credits", "Description" },
                values: new object[,]
                {
                    { "78f92fbe-787d-4370-a258-cf240f6e6ba4", "Mathematics 101", 3, "Introductory math course" },
                    { "fd154aa6-9512-497c-a56d-651ff463bb9c", "History 101", 4, "Introductory history course" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d5e2829f-a08d-4866-a917-67d293d2bc56", "11d175ac-391e-4ed0-bd92-a325e91e7eae" },
                    { "d5e2829f-a08d-4866-a917-67d293d2bc56", "568855ee-f08d-4313-aeb4-c3ed5033a9d5" },
                    { "3c3ed849-49a5-430d-b264-cf283054b935", "8b009732-ba8f-407b-9755-d8a10f36c043" }
                });

            migrationBuilder.InsertData(
                table: "CourseAssignments",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
                    { "78f92fbe-787d-4370-a258-cf240f6e6ba4", "8b009732-ba8f-407b-9755-d8a10f36c043" },
                    { "fd154aa6-9512-497c-a56d-651ff463bb9c", "8b009732-ba8f-407b-9755-d8a10f36c043" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { "26eff6fe-fbea-4d96-946f-da3b3a9def92", "fd154aa6-9512-497c-a56d-651ff463bb9c", 'B', "11d175ac-391e-4ed0-bd92-a325e91e7eae" },
                    { "c0d43dfb-d0d8-4907-8903-97b65783c8a9", "78f92fbe-787d-4370-a258-cf240f6e6ba4", 'A', "568855ee-f08d-4313-aeb4-c3ed5033a9d5" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af45ff5c-c086-4e35-8633-64ba94aef8bf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5e2829f-a08d-4866-a917-67d293d2bc56", "11d175ac-391e-4ed0-bd92-a325e91e7eae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5e2829f-a08d-4866-a917-67d293d2bc56", "568855ee-f08d-4313-aeb4-c3ed5033a9d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c3ed849-49a5-430d-b264-cf283054b935", "8b009732-ba8f-407b-9755-d8a10f36c043" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "78f92fbe-787d-4370-a258-cf240f6e6ba4", "8b009732-ba8f-407b-9755-d8a10f36c043" });

            migrationBuilder.DeleteData(
                table: "CourseAssignments",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { "fd154aa6-9512-497c-a56d-651ff463bb9c", "8b009732-ba8f-407b-9755-d8a10f36c043" });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "26eff6fe-fbea-4d96-946f-da3b3a9def92");

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: "c0d43dfb-d0d8-4907-8903-97b65783c8a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c3ed849-49a5-430d-b264-cf283054b935");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5e2829f-a08d-4866-a917-67d293d2bc56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11d175ac-391e-4ed0-bd92-a325e91e7eae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "568855ee-f08d-4313-aeb4-c3ed5033a9d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b009732-ba8f-407b-9755-d8a10f36c043");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "78f92fbe-787d-4370-a258-cf240f6e6ba4");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "fd154aa6-9512-497c-a56d-651ff463bb9c");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_SenderId",
                table: "Message",
                newName: "IX_Message_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ReceiverId",
                table: "Message",
                newName: "IX_Message_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "MessageId");

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
    }
}
