public class Event
{
    protected string _title;
    protected string _date;
    private string _time;
    private Address _address;

    public Event()
    {

    }
    public Event(string title, string date, string time, Address address)
    {
        _title = title;
        _date = date;
        _time = time;
        _address = address;
    }
    public void PrintStandardDetails()
    {
        Console.WriteLine($"{_title}: {_date} {_time} | {_address.GetAddress()}");
    }
}