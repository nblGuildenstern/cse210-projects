public class Goal
{
    protected string _title;
    protected string _description;
    protected int _timesCompleted;
    protected bool _completed;
    protected int _pointValue;

    public Goal()
    {

    }
    public Goal(string title, string description, int pointValue)
    {
        _title = title;
        _description = description;
        _timesCompleted = 0;
        _completed = false;
        _pointValue = pointValue;
    }
    public Goal(string title, string description, int timesCompleted, int pointValue)
    {
        _title = title;
        _description = description;
        _timesCompleted = timesCompleted;
        _completed = false;
        _pointValue = pointValue;
    }
    public bool IsCompleted()
    {
        return _completed;
    }
    public virtual int Bump()
    {
        return 0;
    }
    public virtual void DisplayGoal()
    {

    }

    public virtual string GetSaveLine()
    {
        return null;
    }
}