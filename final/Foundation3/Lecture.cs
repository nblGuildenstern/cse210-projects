public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture()
    {
        
    }
    public Lecture(string title, string date, string time, Address address, string speaker, int capacity) : base(title, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = capacity;
    }
    public void PrintFullDetails()
    {
        PrintStandardDetails();
        Console.WriteLine($"Lecture | Speaker: {_speaker} | Capacity: {_maxCapacity}");
    }
    public void PrintShortDescription()
    {
        Console.WriteLine($"Lecture | {_title} | {_date}");
    }
}