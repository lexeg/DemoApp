namespace DemoApp.DataAccess
{
    public partial class StudentCourses
    {
        public int id { get; set; }

        public int studentId { get; set; }

        public int coursesId { get; set; }

        public int? mark { get; set; }

        public virtual Courses Courses { get; set; }

        public virtual Students Students { get; set; }
    }
}
