public class Activity
{
    private string _date;
    protected int _length;
    public Activity()
    {

    }
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    protected virtual double GetDistance()
    {
        return 0;
    }
    //Gets speed in mph
    protected virtual double GetSpeed()
    {
        return 0;
    }
    //Gets pace in minutes per mile
    protected virtual double GetPace()
    {
        return 0;
    }
    public void PrintSummary()
    {
        Console.WriteLine($"{_date} {this.GetType()} ({_length} min)- Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile");
    }
}