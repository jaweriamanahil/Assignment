using Session1Tasks.Queries;
using Session1Tasks.Services;
using Session1Tasks.Models;

Console.WriteLine("==============================");
Console.WriteLine("   SESSION 1 TASKS — OUTPUT   ");
Console.WriteLine("==============================\n");

// Task 1.3 — LINQ Queries
LinqQueries.RunAll();

// Task 1.5 — BookService demo
Console.WriteLine("\n=== BookService — GetAll ===");
IBookService service = new BookService();
service.GetAll().ForEach(b => Console.WriteLine($"  [{b.Id}] {b.Title}"));

Console.WriteLine("\n=== BookService — GetById(2) ===");
var book = service.GetById(2);
Console.WriteLine(book is not null ? $"  Found: {book.Title}" : "  Not found");

Console.WriteLine("\n=== BookService — Create ===");
var newBook = service.Create(new Book { Title = "Test Driven Development", Year = 2002, PageCount = 345, AuthorId = 2 });
Console.WriteLine($"  Created: [{newBook.Id}] {newBook.Title}");

Console.WriteLine("\n=== BookService — Delete(1) ===");
var deleted = service.Delete(1);
Console.WriteLine($"  Deleted: {deleted}");
Console.WriteLine($"  Books remaining: {service.GetAll().Count}");
