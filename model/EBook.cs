using System;

public class EBook : Media
{
    // Properties specific to EBook
    public string Author { get; set; }
    public double FileSizeMB { get; set; }

    // Constructor
    public EBook(string title, int publicationYear, string author, double fileSizeMB)
        : base(title, publicationYear)
    {
        Author = author;
        FileSizeMB = fileSizeMB;

        // EBooks can be borrowed for 21 days
        LoanPeriodDays = 21;
    }

    // Override ShowInfo method
    public override void ShowInfo()
    {
        Console.WriteLine($"[{MediaID}] EBook: '{Title}' by {Author} - {FileSizeMB} MB");
    }
}
