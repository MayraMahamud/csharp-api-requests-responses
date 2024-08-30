using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public Student AddStudents(Student student)
        {
           return StudentCollection.Add(student);
        }

        public Student DeleteStudent(string studentName)
        {
            return StudentCollection.DeleteStudent(studentName);
        }

        public List<Student> GetAllStudents()
        {
            return StudentCollection.GetAll();
        }

        public Student GetAStudent(string studentName)
        {
            return StudentCollection.GetAStudent(studentName);
           
        }

        public Student UpdateStudent(string studentName, StudentPut model)
        {
            return StudentCollection.UpdateStudent(studentName, model);

        }

    }
}
