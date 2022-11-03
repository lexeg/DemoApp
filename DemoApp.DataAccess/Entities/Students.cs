using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.DataAccess.Entities
{
    public class Students
    {
        public Students()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        public bool gender { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateBirth { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
