using Microsoft.AspNetCore.Mvc;


using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;


namespace exercise.wwwapi.Endpoints
{
    public static class StudentEndpoints
    {
        
        
            public static void ConfigureStudentEndpoint(this WebApplication app)
            {
                var student = app.MapGroup("students");
                student.MapGet("/", GetAll);
                student.MapPost("/", Add);
            student.MapDelete("/{firstname}",DeleteStudent);
            student.MapGet("/{firstname}", GetAStudent);
            student.MapPut("/{firstname}", UpdateStudent);
            
            }
          
            [ProducesResponseType(StatusCodes.Status200OK)]
            public static IResult GetAll(IStudentRepository repository)
            {
            return TypedResults.Ok(repository.GetAllStudents());

            }
         
        [ProducesResponseType(StatusCodes.Status201Created)]
            public static IResult Add(IStudentRepository repository, Student model)
            {
            
             var result = repository.AddStudents(model);


            return TypedResults.Created("",result);
            }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult DeleteStudent(IStudentRepository repository, string firstname)
        {

            var result = repository.DeleteStudent(firstname);


            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult GetAStudent(IStudentRepository repository, string firstname)
        {

            var result = repository.GetAStudent(firstname);


            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static IResult UpdateStudent(IStudentRepository repository, string firstname,StudentPut model)
        {

            var result = repository.UpdateStudent(firstname, model);


            return TypedResults.Created($"https://localhost:7068/students/{result.FirstName}", result);
        }
    }
}
