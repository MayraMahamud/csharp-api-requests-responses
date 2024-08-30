using Microsoft.AspNetCore.Mvc;


using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;


namespace exercise.wwwapi.Endpoints
{
    public static class BookEndpoints
    {


        public static void ConfigureBookEndpoint(this WebApplication app)
        {
            var book = app.MapGroup("book");
            book.MapGet("/", GetAllBooks);
            book.MapPost("/", AddBook);
            book.MapDelete("/{name}", DeleteBook);
            book.MapGet("/{name}", GetABook);
            book.MapPut("/{name}", UpdateBook);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult GetAllBooks(IBookRepo repository)
        {
            return TypedResults.Ok(repository.GetAllBooks());

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static IResult AddBook(IBookRepo repository, Book model)
        {

            var result = repository.AddBook(model);


            return TypedResults.Created("", result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult DeleteBook(IBookRepo repository, string title)
        {

            var result = repository.DeleteBook(title);


            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult GetABook(IBookRepo repository, string title)
        {

            var result = repository.GetABook(title);


            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static IResult UpdateBook(IBookRepo repository, string title, BookPut model)
        {

            var result = repository.UpdateBook(title, model);


            return TypedResults.Created($"https://localhost:7068/books/{result.Title}", result);
        }
    }
}
