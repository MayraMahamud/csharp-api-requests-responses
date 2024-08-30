using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public static class BookCollection
    {
        private static List<Book> books = new List<Book>()
        {
            new Book() { Title ="Hunger Games" },
            new Book() { Title ="Twilight" }
        };
        public static Book AddBook(Book book)
        {
            books.Add(book);

            return book;
        }

        public static List<Book> GetAllBooks()
        {
            return books.ToList();
        }

        public static Book DeleteBook(string title)
        {
            var entity = books.FirstOrDefault(b => b.Title == title);
            books.RemoveAll(b => b.Title == title);
            return entity;

        }

        public static Book GetABook(string title)
        {
            var entity = books.FirstOrDefault(b => b.Title == title);

            return entity;

        }

        public static Book UpdateBook(string title, BookPut model)
        {
            var entity = books.FirstOrDefault(b => b.Title == title);
            entity.Title = model.Title;

            return entity;

        }
    }


}

