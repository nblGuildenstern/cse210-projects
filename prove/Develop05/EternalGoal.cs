public class EternalGoal : Goal
{
    public EternalGoal()
    {
        Console.Clear();
        Console.Write("What will the title be: ");
        _title = Console.ReadLine();
        Console.Write("What will the description be: ");
        _description = Console.ReadLine();
        Console.Write("How many points will you get each time you complete it: ");
        _pointValue = int.Parse(Console.ReadLine());
    }
    public EternalGoal(string title, string description, int pointValue) : base(title, description, pointValue)
    {

    }
    public EternalGoal(string title, string description, int timesCompleted, int pointValue) : base(title, description, timesCompleted, pointValue)
    {

    }

    public override int Bump()
    {
        _timesCompleted++;
        return _pointValue;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"(Eternal) {_title}: {_description} | Completed {_timesCompleted} times | Worth {_pointValue} points.");
    }

    public override string GetSaveLine()
    {
        return $"Eternal#{_title}#{_description}#{_timesCompleted}#{_pointValue}";
    }

}