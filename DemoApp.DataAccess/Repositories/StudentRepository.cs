using System.Linq;
using DemoApp.DataAccess.Contexts;
using DemoApp.DataAccess.Entities;

namespace DemoApp.DataAccess.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentsDbContext _studentsDbContext;

        public StudentRepository(StudentsDbContext studentsDbContext)
        {
            this._studentsDbContext = studentsDbContext;
        }

        public void Create(StudentEntity studentEntity)
        {
            _studentsDbContext.Students.Add(studentEntity);
            _studentsDbContext.SaveChanges();
        }

        public int Delete(int studentId)
        {
            var student = _studentsDbContext
                .Students
                .FirstOrDefault(s => s.Id == studentId);
            if(student==null) return 0;
            var result = _studentsDbContext.Students.Remove(student);
            _studentsDbContext.SaveChanges();
            return result.Id;
        }

        public StudentEntity[] GetStudents()
        {
            return _studentsDbContext.Students.ToArray();
        }

        public int Update(StudentEntity studentEntity)
        {
            var s = _studentsDbContext.Students.FirstOrDefault(x => x.Id == studentEntity.Id);
            if (s == null) return 0;
            s.Name = studentEntity.Name;
            s.Address = studentEntity.Address;
            s.Gender = studentEntity.Gender;
            s.DateBirth = studentEntity.DateBirth;
            return 1;
        }
    }
}
