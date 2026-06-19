namespace Session1Tasks.Services;
using Session1Tasks.Data;
using Session1Tasks.Models;

public class BookService : IBookService
{
    public List<Book> GetAll() => InMemoryStore.Books;

    public Book? GetById(int id) =>
        InMemoryStore.Books.FirstOrDefault(b => b.Id == id);

    public Book Create(Book book)
    {
        book.Id = InMemoryStore.Books.Max(b => b.Id) + 1;
        InMemoryStore.Books.Add(book);
        return book;
    }

    public Book? Update(int id, Book updated)
    {
        var existing = InMemoryStore.Books.FirstOrDefault(b => b.Id == id);
        if (existing is null) return null;

        existing.Title     = updated.Title;
        existing.Year      = updated.Year;
        existing.PageCount = updated.PageCount;
        existing.AuthorId  = updated.AuthorId;
        return existing;
    }

    public bool Delete(int id)
    {
        var book = InMemoryStore.Books.FirstOrDefault(b => b.Id == id);
        if (book is null) return false;
        InMemoryStore.Books.Remove(book);
        return true;
    }
}