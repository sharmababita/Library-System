using System;

public class Loan
{
    private static int counter = 1;

    public string LoanID { get; }
    public Media Media { get; }
    public User User { get; }
    public DateTime LoanDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnedDate { get; private set; }

    public Loan(Media media, User user)
    {
        Media = media;
        User = user;
        LoanDate = DateTime.Now;
        DueDate = LoanDate.AddDays(media.LoanPeriodDays);

        LoanID = "L" + counter.ToString("D3");
        counter++;
    }

    // Mark the media as returned
    public void ReturnMedia()
    {
        ReturnedDate = DateTime.Now;
        Media.IsBorrowed = false;
    }

    // Check if the loan is late
    public bool IsLate()
    {
        return ReturnedDate == null && DateTime.Now > DueDate;
    }
}
