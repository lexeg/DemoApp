using DemoApp.DataAccess;
using DemoApp.DataAccess.Repositories;
using System.Configuration;
using System.Windows;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"]
                .ConnectionString;
            var studentsDbContext = new StudentsDbContext(connectionString);
            var studentRepository = new StudentRepository(studentsDbContext);
            var students = studentRepository.GetStudents();
        }
    }
}
