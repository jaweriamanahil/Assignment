namespace Session1Tasks.Services;
using Session1Tasks.Models;

public interface IBookService
{
    List<Book> GetAll();
    Book? GetById(int id);
    Book Create(Book book);
    Book? Update(int id, Book updated);
    bool Delete(int id);
}