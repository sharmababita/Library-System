using System;

public abstract class Media
{
    // Static counter to generate unique Media IDs
    private static int counter = 1;

    // Private fields (encapsulation)
    private string title;
    private int publicationYear;
    private bool isBorrowed;

    // Property for Title
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    // Read-only property for MediaID (auto-generated)
    public string MediaID { get; }

    // Property with validation for publication year
    public int PublicationYear
    {
        get { return publicationYear; }
        set
        {
            if (value < 1800 || value > 2026)
                throw new ArgumentException("Publication year must be between 1800 and 2026.");
            publicationYear = value;
        }
    }

    // Property for loan status
    public bool IsBorrowed
    {
        get { return isBorrowed; }
        set { isBorrowed = value; }
    }

    // Property for loan period (set by child classes)
    public int LoanPeriodDays { get; protected set; }

    // Constructor
    public Media(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
        IsBorrowed = false;

        // Generate unique ID like M001, M002, etc.
        MediaID = "M" + counter.ToString("D3");
        counter++;
    }

    // Abstract method that must be implemented by all subclasses
    public abstract void ShowInfo();
}
