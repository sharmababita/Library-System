public class Member : User
{
    public Member(string name, string email) : base(name, email)
    {
    }

    // Members can borrow up to 5 media items
    public override bool CanBorrow()
    {
        return BorrowedMedia.Count < 5;
    }
}
