using System;

public class Book : Media
{
    // Additional properties specific to Book
    public string Author { get; set; }
    public int PageCount { get; set; }

    // Constructor
    public Book(string title, int publicationYear, string author, int pageCount)
        : base(title, publicationYear) // Call base class constructor
    {
        Author = author;
        PageCount = pageCount;

        // Books can be borrowed for 14 days
        LoanPeriodDays = 14;
    }

    // Override abstract method from Media
    public override void ShowInfo()
    {
        Console.WriteLine($"[{MediaID}] Book: '{Title}' by {Author} ({PublicationYear}) - {PageCount} pages");
    }
}
