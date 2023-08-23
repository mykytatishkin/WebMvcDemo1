using WebMvcDemo1.Models;

namespace WebMvcDemo1.Repositories
{
    public class ListStudents : IStudents
    {

        public static List<Student> students = new List<Student>();
        
        public ListStudents() 
        {
            Group g1 = new Group();
            Group g2 = new Group();
            Group g3 = new Group();
            g1.Id = 1;
            g1.GroupName = "G1";
            g2.Id = 2;
            g2.GroupName = "G2";
            g3.Id = 3;
            g3.GroupName = "G3";

            students.Clear();
            students.Add(new Student() { Id = 1, Name = "Clifford Simak", Group = g1.GroupName, Rate = 12, GroupID = g1.Id, group = g1 });
            students.Add(new Student() { Id = 2, Name = "Isaac Azimov", Group = g2.GroupName, Rate = 11, GroupID = g2.Id, group = g2});
            students.Add(new Student() { Id = 3, Name = "Roger Zhelyazny", Group = g3.GroupName, Rate = 12, GroupID = g3.Id, group = g3});
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
