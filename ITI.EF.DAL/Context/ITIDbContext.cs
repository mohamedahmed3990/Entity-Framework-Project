using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ITI.EF.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLab2.Context
{
    public class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8QITL5G\\SQLEXPRESS; database=ITI_EF_Project; Trusted_Connection=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            var DepartmentsSeed = new List<Department>
            {
                new Department { DeptId = 1, DeptName = "SD" , DeptDesc = "cairo"},
                new Department { DeptId = 2, DeptName = "UI&UX" , DeptDesc = "Designer"},
                new Department { DeptId = 3, DeptName = "Network", DeptLocation = "Alex"},
                new Department { DeptId = 4, DeptName = "OS"}
            };

            var CoursesSeed = new List<Course>
            {
                new Course {Crs_Id = 100, Crs_Name = "OOP", Crs_Duration = 4},
                new Course {Crs_Id = 200, Crs_Name = "C#", Crs_Duration = 5},
                new Course {Crs_Id = 300, Crs_Name = "Java", Crs_Duration = 5},
                new Course {Crs_Id = 400, Crs_Name = "SqlServer", Crs_Duration = 3},
            };

            var TopicSeed = new List<Topic>
            {
                new Topic {Id = 1, TopicName = "Programming"},
                new Topic {Id = 2, TopicName = "Security"},
            };

            modelBuilder.Entity<Department>()
                .HasData(DepartmentsSeed);

            modelBuilder.Entity<Course>()
                .HasData(CoursesSeed);

            modelBuilder.Entity<Topic>()
              .HasData(TopicSeed);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<InstructorCourse> InstructorCourses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }


        
    }
}
