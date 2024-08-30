using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class BookRepo : IBookRepo
    {
        public Book AddBook(Book book)
        {
            return BookCollection.AddBook(book);
        }

        public Book DeleteBook(string bookName)
        {
            return BookCollection.DeleteBook(bookName);
        }

        public List<Book> GetAllBooks()
        {
            return BookCollection.GetAllBooks();
        }

        public Book GetABook(string bookName)
        {
            return BookCollection.GetABook(bookName);

        }

        public Book UpdateBook(string bookName, BookPut model)
        {
            return BookCollection.UpdateBook(bookName, model);

        }

       
    }


}

