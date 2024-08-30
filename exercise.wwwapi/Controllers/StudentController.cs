using exercise.wwwapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace exercise.wwwapi.Controllers
{
    [ApiController]
    [Route("students")]

    

    public class StudentController : ControllerBase
    {
        public static List<Student> students = new List<Student>();
      

        public StudentController()
        {
            
        }


        [HttpPost]
        [Route("student")]
        public IResult CreateStudent(Student student)
        {
            students.Add(student);
            

            return TypedResults.Ok(student);

        }


        [HttpGet]
        [Route("getstudents")]
        public IResult GetAllStudents()
        {
           

            return TypedResults.Ok(students);

        }


        [HttpGet]
        [Route("getAstudent")]
        public IResult GetStudent(int id)
        {
            var student = students.Find(s => s.Id == id);

           return student != null ? TypedResults.Ok(student) : TypedResults.NotFound();
          
        }  

        [HttpPut]
        [Route("updatestudent")]
        public IResult UpdateStudent(int id, Student updatedStudent)
        {
            var existingStudent = students.Find(s => s.Id == id);
            if (existingStudent != null)
            {

                existingStudent.FirstName = updatedStudent.FirstName;
                existingStudent.LastName = updatedStudent.LastName;
                existingStudent.Id = updatedStudent.Id;
            }

            return TypedResults.Ok(updatedStudent);


        }

        [HttpDelete]
        [Route("deletestudent")]
        public IResult DeleteStudent(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            return TypedResults.NotFound();
        }


    }
}
