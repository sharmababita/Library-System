using System;

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        // Create media
        Book book1 = new Book("1984", 1949, "George Orwell", 328);
        AudioBook audio1 = new AudioBook("Sapiens", 2011, "Yuval Harari", new TimeSpan(15, 17, 0));
        EBook ebook1 = new EBook("Clean Code", 2008, "Robert Martin", 2.8);
        Magazine mag1 = new Magazine("National Geographic", 2026, 3, "March");

        library.AddMedia(book1);
        library.AddMedia(audio1);
        library.AddMedia(ebook1);
        library.AddMedia(mag1);

        // Create users
        Member member1 = new Member("Kari Nordmann", "kari@email.com");
        Staff staff1 = new Staff("Ola Hansen", "ola@library.no");

        library.AddUser(member1);
        library.AddUser(staff1);

        // Borrow
        library.BorrowMedia("M001", member1.UserID);

        Console.WriteLine();
        library.SearchByTitle("1984");

        Console.WriteLine();
        library.ReturnMedia("M001");

        Console.ReadLine();
    }
}
