using System.Linq;

namespace DemoApp.DataAccess.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentsDbContext studentsDbContext;

        public StudentRepository(StudentsDbContext studentsDbContext)
        {
            this.studentsDbContext = studentsDbContext;
        }

        public void Create(Students student)
        {
            studentsDbContext.Students.Add(student);
            studentsDbContext.SaveChanges();
        }

        public int Delete(int studentId)
        {
            var student = studentsDbContext
                .Students
                .FirstOrDefault(s => s.id == studentId);
            if(student==null) return 0;
            var result = studentsDbContext.Students.Remove(student);
            studentsDbContext.SaveChanges();
            return result.id;
        }

        public Students[] GetStudents()
        {
            return studentsDbContext.Students.ToArray();
        }

        public int Update(Students student)
        {
            var s = studentsDbContext.Students.FirstOrDefault(x => x.id == student.id);
            if (s == null) return 0;
            s.name = student.name;
            s.address = student.address;
            s.gender = student.gender;
            s.dateBirth = student.dateBirth;
            return 1;
        }
    }
}
