using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface IBookRepo
    {
        List<Book> GetAllBooks();
        Book AddBook(Book book);
        Book DeleteBook(string bookName);
        Book GetABook(string bookName);
        Book UpdateBook(string bookName, BookPut model);
    }
}
