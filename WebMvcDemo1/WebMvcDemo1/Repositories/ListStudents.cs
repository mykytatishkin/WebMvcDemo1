using WebMvcDemo1.Models;

namespace WebMvcDemo1.Repositories
{
    public class ListStudents : IStudents
    {

        public static List<Student> students = new List<Student>();
        
        public ListStudents() 
        { 
            students.Clear();
            students.Add(new Student() { Id = 1, Name = "Clifford Simak", Group = "123", Rate = 12});
            students.Add(new Student() { Id = 2, Name = "Isaac Azimov", Group = "123", Rate = 11});
            students.Add(new Student() { Id = 3, Name = "Roger Zhelyazny", Group = "123", Rate = 12});
        }

        public Student? AddStudent(Student student)
        {
            try
            {
                students.Add(student);
                return student;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
