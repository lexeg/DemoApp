using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoApp.DataAccess.Entities
{
    public class Courses
    {
        public Courses()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
