using System;

public class AudioBook : Media
{
    // Properties specific to AudioBook
    public string Author { get; set; }
    public TimeSpan Duration { get; set; }

    // Constructor
    public AudioBook(string title, int publicationYear, string author, TimeSpan duration)
        : base(title, publicationYear)
    {
        Author = author;
        Duration = duration;

        // Audiobooks can be borrowed for 7 days
        LoanPeriodDays = 7;
    }

    // Override ShowInfo method
    public override void ShowInfo()
    {
        Console.WriteLine($"[{MediaID}] AudioBook: '{Title}' by {Author} - {Duration}");
    }
}
