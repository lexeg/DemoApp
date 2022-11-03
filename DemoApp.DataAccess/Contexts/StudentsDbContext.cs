using System.Data.Entity;

namespace DemoApp.DataAccess
{
    public partial class StudentsDbContext : DbContext
    {
        public StudentsDbContext(string connectionString): base(connectionString)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<StudentCourses> StudentCourses { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.Courses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Students>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.Students)
                .HasForeignKey(e => e.studentId)
                .WillCascadeOnDelete(false);
        }
    }
}
