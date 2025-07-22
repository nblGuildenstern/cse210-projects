public class Swimming : Activity
{
    private int _lapCount;
    public Swimming()
    {

    }
    public Swimming(string date, int length, int lapCount) : base(date, length)
    {
        _lapCount = lapCount;
    }
    protected override double GetDistance()
    {
        return (double)_lapCount * 50 / 1000 * 0.62;
    }
    //Gets speed in mph
    protected override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
    //Gets pace in minutes per mile
    protected override double GetPace()
    {
        return _length / GetDistance();
    }
}