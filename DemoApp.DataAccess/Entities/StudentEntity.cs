using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.DataAccess.Entities
{
    [Table("Students")]
    public class StudentEntity
    {
        public StudentEntity()
        {
            StudentCourses = new HashSet<StudentCoursesEntity>();
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Column("gender")]
        public bool Gender { get; set; }

        [Column("address")]
        [StringLength(200)]
        public string Address { get; set; }

        [Column("dateBirth", TypeName = "date")]
        public DateTime? DateBirth { get; set; }

        public virtual ICollection<StudentCoursesEntity> StudentCourses { get; set; }
    }
}
