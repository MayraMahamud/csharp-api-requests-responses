using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface ILanguageRepo
    {
        List<Language> GetAllLanguages();
        Language AddLanguage(Language language);
        Language DeleteLanguage(string languageName);
        Language GetALanguage(string languageName);
        Language UpdateLanguage(string languageName, LanguagePut model);
    }
}