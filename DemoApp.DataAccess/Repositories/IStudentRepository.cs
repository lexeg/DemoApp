namespace DemoApp.DataAccess.Repositories
{
    public interface IStudentRepository
    {
        Students[] GetStudents();
        void Create(Students student);
        int Update(Students student);
        int Delete(int studentId);
    }
}
