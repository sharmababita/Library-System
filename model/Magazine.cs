using System;

public class Magazine : Media
{
    public int IssueNumber { get; set; }
    public string Month { get; set; }

    public Magazine(string title, int publicationYear, int issueNumber, string month)
        : base(title, publicationYear)
    {
        IssueNumber = issueNumber;
        Month = month;

        // Magazines can be borrowed for 3 days
        LoanPeriodDays = 3;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"[{MediaID}] Magazine: '{Title}' - Issue {IssueNumber}, {Month} {PublicationYear}");
    }
}
