using System.Data.Entity;
using DemoApp.DataAccess.Entities;

namespace DemoApp.DataAccess.Contexts
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(string connectionString): base(connectionString)
        {
        }

        public virtual DbSet<CourseEntity> Courses { get; set; }
        public virtual DbSet<StudentCoursesEntity> StudentCourses { get; set; }
        public virtual DbSet<StudentEntity> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEntity>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.Courses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentEntity>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.Students)
                .HasForeignKey(e => e.StudentId)
                .WillCascadeOnDelete(false);
        }
    }
}
