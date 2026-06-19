namespace Session1Tasks.Data;
using Session1Tasks.Models;

public static class InMemoryStore
{
    public static List<Author> Authors { get; } = new()
    {
        new Author { Id = 1, Name = "Robert C. Martin" },
        new Author { Id = 2, Name = "Martin Fowler" },
        new Author { Id = 3, Name = "Andrew Hunt" },
    };

    public static List<Book> Books { get; } = new()
    {
        new Book { Id = 1, Title = "Clean Code",               Year = 2008, PageCount = 431, AuthorId = 1 },
        new Book { Id = 2, Title = "The Clean Coder",          Year = 2011, PageCount = 256, AuthorId = 1 },
        new Book { Id = 3, Title = "Clean Architecture",       Year = 2017, PageCount = 432, AuthorId = 1 },
        new Book { Id = 4, Title = "Refactoring",              Year = 1999, PageCount = 448, AuthorId = 2 },
        new Book { Id = 5, Title = "Patterns of Enterprise",   Year = 2002, PageCount = 560, AuthorId = 2 },
        new Book { Id = 6, Title = "The Pragmatic Programmer", Year = 1999, PageCount = 352, AuthorId = 3 },
        new Book { Id = 7, Title = "Domain-Driven Design",     Year = 2003, PageCount = 560, AuthorId = 2 },
        new Book { Id = 8, Title = "Agile Principles",         Year = 2002, PageCount = 616, AuthorId = 1 },
    };

    public static List<Tag> Tags { get; } = new()
    {
        new Tag { Id = 1, Name = "Clean Code" },
        new Tag { Id = 2, Name = "Architecture" },
        new Tag { Id = 3, Name = "Refactoring" },
        new Tag { Id = 4, Name = "Agile" },
    };

    public static List<BookTag> BookTags { get; } = new()
    {
        new BookTag { BookId = 1, TagId = 1 },
        new BookTag { BookId = 2, TagId = 1 },
        new BookTag { BookId = 3, TagId = 2 },
        new BookTag { BookId = 4, TagId = 3 },
        new BookTag { BookId = 5, TagId = 2 },
        new BookTag { BookId = 8, TagId = 4 },
    };
}