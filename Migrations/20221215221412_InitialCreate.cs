using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Accounts" },
                    { 4, "Payroll" },
                    { 5, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "john.Doe@email.com", "John", 0, "Doe", "Images/john.png" },
                    { 2, new DateTime(1980, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Frank.Hughes@email.com", "Frank", 0, "Hughes", "Images/frank.png" },
                    { 3, new DateTime(1994, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Rose.Marfo@email.com", "Rose", 1, "Marfo", "Images/rose.png" },
                    { 4, new DateTime(2000, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Sandra.Armah@email.com", "Sandra", 1, "Armah", "Images/sandra.png" },
                    { 5, new DateTime(1987, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Dennis.Marfo@email.com", "Dennis", 0, "Marfo", "Images/dennis.png" },
                    { 6, new DateTime(2001, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Mabel.Abekah@email.com", "Mabel", 1, "Abekah", "Images/mabel.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
