using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents ();
        Student AddStudents (Student student);
        Student DeleteStudent(string studentName);
        Student GetAStudent (string studentName);
        Student UpdateStudent (string studentName, StudentPut model);
    }
}
