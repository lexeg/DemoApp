using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.DataAccess.Entities
{
    [Table("Courses")]
    public class CourseEntity
    {
        public CourseEntity()
        {
            StudentCourses = new HashSet<StudentCoursesEntity>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public virtual ICollection<StudentCoursesEntity> StudentCourses { get; set; }
    }
}
