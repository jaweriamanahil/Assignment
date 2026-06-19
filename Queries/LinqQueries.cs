namespace Session1Tasks.Queries;
using Session1Tasks.Data;

public static class LinqQueries
{
    public static void RunAll()
    {
        var books   = InMemoryStore.Books;
        var authors = InMemoryStore.Authors;

        // 1. Filter books by a specific author (AuthorId = 1)
        Console.WriteLine("=== 1. Books by Robert C. Martin ===");
        var byAuthor = books.Where(b => b.AuthorId == 1).ToList();
        byAuthor.ForEach(b => Console.WriteLine($"  {b.Title}"));

        // 2. All titles sorted alphabetically
        Console.WriteLine("\n=== 2. Titles Sorted A-Z ===");
        var sorted = books.Select(b => b.Title).OrderBy(t => t).ToList();
        sorted.ForEach(t => Console.WriteLine($"  {t}"));

        // 3. Group books by AuthorId
        Console.WriteLine("\n=== 3. Grouped by Author ===");
        var grouped = books.GroupBy(b => b.AuthorId);
        foreach (var group in grouped)
        {
            var authorName = authors.FirstOrDefault(a => a.Id == group.Key)?.Name ?? "Unknown";
            Console.WriteLine($"  {authorName}:");
            group.ToList().ForEach(b => Console.WriteLine($"    - {b.Title}"));
        }

        // 4. Average page count
        Console.WriteLine("\n=== 4. Average Page Count ===");
        var avg = books.Average(b => b.PageCount);
        Console.WriteLine($"  {avg:F1} pages");

        // 5. Any book with more than 500 pages?
        Console.WriteLine("\n=== 5. Any Book > 500 Pages? ===");
        var hasLong = books.Any(b => b.PageCount > 500);
        Console.WriteLine($"  {hasLong}");

        // 6. FirstOrDefault — find book with Id = 4
        Console.WriteLine("\n=== 6. FirstOrDefault — Id = 4 ===");
        var found = books.FirstOrDefault(b => b.Id == 4);
        Console.WriteLine(found is not null ? $"  {found.Title}" : "  Not found");

        // 7. Join books + authors
        Console.WriteLine("\n=== 7. Join Books + Authors ===");
        var joined = books.Join(
            authors,
            b => b.AuthorId,
            a => a.Id,
            (b, a) => new { b.Title, AuthorName = a.Name }
        ).ToList();
        joined.ForEach(x => Console.WriteLine($"  \"{x.Title}\" by {x.AuthorName}"));

        // 8. Top 3 longest books by page count
        Console.WriteLine("\n=== 8. Top 3 Longest Books ===");
        var top3 = books.OrderByDescending(b => b.PageCount).Take(3).ToList();
        top3.ForEach(b => Console.WriteLine($"  {b.Title} ({b.PageCount} pages)"));
    }
}