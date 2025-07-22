public class Writing : Assignment
{
    private string _title;
    public Writing(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title} by {_studentName}");
    }
}