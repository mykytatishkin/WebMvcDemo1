using WebMvcDemo1.Models;

namespace WebMvcDemo1.Repositories
{
    public interface IStudents
    {
        List<Student> GetStudents();
        Student? AddStudent(Student student);
    }
}
