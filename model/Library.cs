using System;
using System.Collections.Generic;

public class Library
{
    public List<Media> MediaList { get; private set; }
    public List<User> Users { get; private set; }
    public List<Loan> Loans { get; private set; }

    public Library()
    {
        MediaList = new List<Media>();
        Users = new List<User>();
        Loans = new List<Loan>();
    }

    // Add media
    public void AddMedia(Media media)
    {
        MediaList.Add(media);
    }

    // Add user
    public void AddUser(User user)
    {
        Users.Add(user);
    }

    // Borrow media
    public void BorrowMedia(string mediaID, string userID)
    {
        Media? media = MediaList.Find(m => m.MediaID == mediaID);
        User? user = Users.Find(u => u.UserID == userID);

        if (media == null || user == null)
        {
            Console.WriteLine("Media or User not found.");
            return;
        }

        if (media.IsBorrowed)
        {
            Console.WriteLine("Media is already borrowed.");
            return;
        }

        if (!user.CanBorrow())
        {
            Console.WriteLine("User cannot borrow more items.");
            return;
        }

        Loan loan = new Loan(media, user);
        Loans.Add(loan);

        media.IsBorrowed = true;
        user.BorrowedMedia.Add(media);

        Console.WriteLine("Borrow successful.");
    }

    // Return media
    public void ReturnMedia(string mediaID)
    {
        Loan? loan = Loans.Find(l => l.Media.MediaID == mediaID && l.ReturnedDate == null);

        if (loan == null)
        {
            Console.WriteLine("Active loan not found.");
            return;
        }

        loan.ReturnMedia();
        loan.User.BorrowedMedia.Remove(loan.Media);

        Console.WriteLine("Return successful.");
    }

    // Search by title
    public void SearchByTitle(string title)
    {
        foreach (Media media in MediaList)
        {
            if (media.Title.ToLower().Contains(title.ToLower()))
            {
                media.ShowInfo();
            }
        }
    }
}
