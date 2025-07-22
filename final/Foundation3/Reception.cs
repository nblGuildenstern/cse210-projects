public class Reception : Event
{
    private string _email;
    public Reception()
    {

    }
    public Reception(string title, string date, string time, Address address, string email) : base(title, date, time, address)
    {
        _email = email;
    }
    public void PrintFullDetails()
    {
        PrintStandardDetails();
        Console.WriteLine($"Reception | RSVP AT: {_email}");
    }
    public void PrintShortDescription()
    {
        Console.WriteLine($"Reception | {_title} | {_date}");
    }
}