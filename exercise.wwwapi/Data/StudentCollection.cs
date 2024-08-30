using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public static class StudentCollection
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() { FirstName="Nathan",LastName="King" },
            new Student() { FirstName="Dave", LastName="Ames" }
        };

        public static Student Add(Student student)
        {            
            _students.Add(student);

            return student;
        }

        public static List<Student> GetAll()
        {
            return _students.ToList();
        }

        public static Student DeleteStudent(string firstname) 
        {
            var entity = _students.FirstOrDefault(x => x.FirstName == firstname);
            _students.RemoveAll(s=> s.FirstName== firstname);
            return entity;

        }

        public static Student GetAStudent(string firstname) 
        {
            var entity = _students.FirstOrDefault(x => x.FirstName == firstname);
            
            return entity;

        }

        public static Student UpdateStudent(string firstname, StudentPut model) 
        {
            var entity = _students.FirstOrDefault(x => x.FirstName == firstname);
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;


            return entity;

        }
    }


}
