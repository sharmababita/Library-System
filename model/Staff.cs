using System;

public class Staff : User
{
    // Constructor
    public Staff(string name, string email) : base(name, email)
    {
    }

    // Staff can borrow up to 10 items
    public override bool CanBorrow()
    {
        return BorrowedMedia.Count < 10;
    }
}
