# Session1Tasks

A small .NET 8 console application that demonstrates basic entity modeling, in-memory data storage, LINQ queries, and a simple CRUD service for books.

## Assignment Coverage

This project was built to cover the following tasks:

- Task 1.1: Create entity classes for `Book`, `Author`, `Tag`, and `BookTag`
- Task 1.2: Create an `InMemoryStore` with seeded data
- Task 1.3: Write 8 LINQ queries
- Task 1.4: Create the `IBookService` interface
- Task 1.5: Create `BookService` using the in-memory store

## Project Overview

The application models a simple book catalog:

- Each `Author` can have many `Book` records
- Each `Book` has an `AuthorId` and optional `Author` navigation property
- `Tag` and `BookTag` are included to represent book-to-tag relationships

The app starts in `Program.cs`, runs the LINQ query demo, and then demonstrates the book service with sample `GetAll`, `GetById`, `Create`, and `Delete` operations.

## Data Model

### Author

- `Id`
- `Name`
- `Books`

### Book

- `Id`
- `Title`
- `Year`
- `PageCount`
- `AuthorId`
- `Author`

### Tag

- `Id`
- `Name`

### BookTag

- `BookId`
- `TagId`

## In-Memory Seed Data

`InMemoryStore` provides:

- 3 authors
- 8 books
- 4 tags
- 6 book-tag links

The seeded books include titles such as `Clean Code`, `Refactoring`, `Domain-Driven Design`, and `The Pragmatic Programmer`.

## LINQ Queries

`Queries/LinqQueries.cs` demonstrates 8 LINQ operations:

1. Filter books by a specific author
2. Select and sort all titles alphabetically
3. Group books by author
4. Calculate average page count
5. Check whether any book has more than 500 pages
6. Find a book with `FirstOrDefault`
7. Join books with authors
8. Select the top 3 longest books

## Book Service

`Services/IBookService.cs` defines the CRUD contract:

- `GetAll()`
- `GetById(int id)`
- `Create(Book book)`
- `Update(int id, Book updated)`
- `Delete(int id)`

`Services/BookService.cs` implements this contract against the in-memory list in `InMemoryStore`.

## How To Run

```bash
dotnet run
```

## Expected Output

When the app runs, it prints:

- the 8 LINQ query results
- a `BookService` demo showing all books
- a `GetById(2)` lookup
- a `Create` example
- a `Delete(1)` example

## Project Structure

```text
Program.cs
Session1Tasks.csproj
Data/
  InMemoryStore.cs
Models/
  Author.cs
  Book.cs
  BookTag.cs
  Tag.cs
Queries/
  LinqQueries.cs
Services/
  IBookService.cs
  BookService.cs
```
