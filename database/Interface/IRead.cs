using database.Models;

namespace database.Interface
{
    public interface IRead
    {
         public Book ReadBook();
         public List<Book> ReadAllBooks();
    }
}