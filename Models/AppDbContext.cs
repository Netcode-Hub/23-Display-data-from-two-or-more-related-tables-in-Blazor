using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Department
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Accounts" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Payroll" });

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 5, DepartmentName = "Admin" });


        //Employee
            modelBuilder.Entity<Employee>().HasData(new Employee
                 {
                     EmployeeId = 1,
                     FirstName = "John",
                     LastName = "Doe",
                     Email = "john.Doe@email.com",
                     DateOfBirth = new DateTime(1990, 11, 4),
                     Gender = Gender.Male,
                     DepartmentId = 1,
                     PhotoPath = "Images/john.png"
                 });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Frank",
                LastName = "Hughes",
                Email = "Frank.Hughes@email.com",
                DateOfBirth = new DateTime(1980, 12, 1),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "Images/frank.png"
            });


            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Rose",
                LastName = "Marfo",
                Email = "Rose.Marfo@email.com",
                DateOfBirth = new DateTime(1994, 1, 10),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "Images/rose.png"
            });


            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Sandra",
                LastName = "Armah",
                Email = "Sandra.Armah@email.com",
                DateOfBirth = new DateTime(2000, 11, 9),
                Gender = Gender.Female,
                DepartmentId = 4,
                PhotoPath = "Images/sandra.png"
            });


            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Dennis",
                LastName = "Marfo",
                Email = "Dennis.Marfo@email.com",
                DateOfBirth = new DateTime(1987, 5, 7),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "Images/dennis.png"
            });


            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 6,
                FirstName = "Mabel",
                LastName = "Abekah",
                Email = "Mabel.Abekah@email.com",
                DateOfBirth = new DateTime(2001, 5, 17),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "Images/mabel.png"
            });
        }
    }
}
