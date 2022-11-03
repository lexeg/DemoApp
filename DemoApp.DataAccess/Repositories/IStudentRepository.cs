using DemoApp.DataAccess.Entities;

namespace DemoApp.DataAccess.Repositories
{
    public interface IStudentRepository
    {
        StudentEntity[] GetStudents();
        void Create(StudentEntity studentEntity);
        int Update(StudentEntity studentEntity);
        int Delete(int studentId);
    }
}
