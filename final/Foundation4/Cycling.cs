public class Cycling : Activity
{
    private double _speed;
    public Cycling()
    {

    }
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    protected override double GetDistance()
    {
        return _speed*_length / 60;
    }
    //Gets speed in mph
    protected override double GetSpeed()
    {
        return _speed;
    }
    //Gets pace in minutes per mile
    protected override double GetPace()
    {
        return 60 / _speed;
    }
}