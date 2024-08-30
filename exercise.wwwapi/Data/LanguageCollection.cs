using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{

    public static class LanguageCollection
    {
        private static List<Language> languages = new List<Language>(){
            new Language("Java"),
            new Language("C#")
        };


        public static Language Add(Language language)
        {
            languages.Add(language);

            return language;
        }

        public static List<Language> GetAllLanguages()
        {
            return languages.ToList();
        }

        public static Language DeleteLanguage(string name)
        {
            var entity = languages.FirstOrDefault(x => x.Name == name);
            languages.RemoveAll(s => s.Name == name);
            return entity;

        }

        public static Language GetALanguage(string name)
        {
            var entity = languages.FirstOrDefault(x => x.Name == name);

            return entity;

        }

        public static Language UpdateLanguage(string name, LanguagePut model)
        {
            var entity = languages.FirstOrDefault(x => x.Name == name);
            entity.Name = model.Name;
            
           return entity;

        }
    }


}




