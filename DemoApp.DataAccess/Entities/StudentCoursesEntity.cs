using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.DataAccess.Entities
{
    [Table("StudentCourses")]
    public class StudentCoursesEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("studentId")]
        public int StudentId { get; set; }

        [Column("coursesId")]
        public int CoursesId { get; set; }

        [Column("mark")]
        public int? Mark { get; set; }

        public virtual CourseEntity Courses { get; set; }

        public virtual StudentEntity Students { get; set; }
    }
}
