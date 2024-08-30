using Microsoft.AspNetCore.Mvc;


using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;


namespace exercise.wwwapi.Endpoints
{
    public static class LanguageEndpoints
    {


        public static void ConfigureLanguageEndpoint(this WebApplication app)
        {
            var language = app.MapGroup("language");
            language.MapGet("/", GetAllLanguages);
            language.MapPost("/", AddLanguage);
            language.MapDelete("/{name}", DeleteLanguage);
            language.MapGet("/{name}", GetALanguage);
            language.MapPut("/{name}", UpdateLanguage);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult GetAllLanguages(ILanguageRepo repository)
        {
            return TypedResults.Ok(repository.GetAllLanguages());

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static IResult AddLanguage(ILanguageRepo repository, Language model)
        {

            var result = repository.AddLanguage(model);


            return TypedResults.Created("", result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult DeleteLanguage(ILanguageRepo repository, string name)
        {

            var result = repository.DeleteLanguage(name);


            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult GetALanguage(ILanguageRepo repository, string name)
        {

            var result = repository.GetALanguage(name);


            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static IResult UpdateLanguage(ILanguageRepo repository, string name, LanguagePut model)
        {

            var result = repository.UpdateLanguage(name, model);


            return TypedResults.Created($"https://localhost:7068/languages/{result.Name}", result);
        }
    }
}
