public class Running : Activity
{
    private double _distance;
    public Running()
    {

    }
    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    protected override double GetDistance()
    {
        return _distance;
    }
    //Gets speed in mph
    protected override double GetSpeed()
    {
        return _distance / _length * 60;
    }
    //Gets pace in minutes per mile
    protected override double GetPace()
    {
        return _length / _distance;
    }
}