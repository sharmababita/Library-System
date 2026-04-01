using System;
using System.Collections.Generic;

public abstract class User
{
    private static int counter = 1;

    private string name = "";
    private string email = "";


    // Auto-generated UserID
    public string UserID { get; }

    // Property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property with email validation
    public string Email
    {
        get { return email; }
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Invalid email address.");
            email = value;
        }
    }

    // List of borrowed media
    public List<Media> BorrowedMedia { get; private set; }

    // Constructor
    public User(string name, string email)
    {
        Name = name;
        Email = email;
        BorrowedMedia = new List<Media>();

        // Generate ID like U001
        UserID = "U" + counter.ToString("D3");
        counter++;
    }

    // Abstract method for borrowing permission
    public abstract bool CanBorrow();
}
