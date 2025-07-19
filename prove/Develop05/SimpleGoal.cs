public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        Console.Clear();
        Console.Write("What will the title be: ");
        _title = Console.ReadLine();
        Console.Write("What will the description be: ");
        _description = Console.ReadLine();
        Console.Write("How much will this goal be worth once completed: ");
        _pointValue = int.Parse(Console.ReadLine());
    }
    public SimpleGoal(string title, string description, int pointValue) : base(title, description, pointValue)
    {

    }
    public SimpleGoal(string title, string description, int timesCompleted, bool completed, int pointValue) : base(title, description, timesCompleted, pointValue)
    {
        _completed = completed;
    }
    public override int Bump()
    {
        if (!_completed)
        {
            _timesCompleted++;
            _completed = true;
            return _pointValue;
        }
        return 0;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"(Simple) {_title}: {_description} | {(_completed == true ? "Complete" : "Incomplete")} | Worth {_pointValue} points.");
    }

    public override string GetSaveLine()
    {
        return $"Simple#{_title}#{_description}#{_timesCompleted}#{_completed.ToString()}#{_pointValue}";
    }

}