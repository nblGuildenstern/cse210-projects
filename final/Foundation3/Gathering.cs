public class Gathering : Event
{
    private string _weather;
    public Gathering()
    {

    }
    public Gathering(string title, string date, string time, Address address, string weather) : base(title, date, time, address)
    {
        _weather = weather;
    }
    public void PrintFullDetails()
    {
        PrintStandardDetails();
        Console.WriteLine($"Outdoor Gathering | {_weather}");
    }
    public void PrintShortDescription()
    {
        Console.WriteLine($"Outdoor Gathering | {_title} | {_date}");
    }
}