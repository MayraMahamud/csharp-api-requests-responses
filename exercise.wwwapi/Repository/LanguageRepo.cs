using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class LanguageRepo : ILanguageRepo
    {
        public Language AddLanguage(Language language)
        {
            return LanguageCollection.Add(language);
        }

        public Language DeleteLanguage(string languageName)
        {
            return LanguageCollection.DeleteLanguage(languageName);
        }

        public List<Language> GetAllLanguages()
        {
            return LanguageCollection.GetAllLanguages();
        }

        public Language GetALanguage(string languageName)
        {
            return LanguageCollection.GetALanguage(languageName);

        }

        public Language UpdateLanguage(string languageName, LanguagePut model)
        {
            return LanguageCollection.UpdateLanguage(languageName, model);

        }

       
    }

    
}

