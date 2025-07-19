public class ChecklistGoal : Goal
{
    private int _countGoal;
    private int _completionBonus;
    public ChecklistGoal()
    {
        Console.Clear();
        Console.Write("What will the title be: ");
        _title = Console.ReadLine();
        Console.Write("What will the description be: ");
        _description = Console.ReadLine();
        Console.Write("How many points will you get each time you complete it: ");
        _pointValue = int.Parse(Console.ReadLine());
        Console.Write("How many times will you need to complete this goal: ");
        _countGoal = int.Parse(Console.ReadLine());
        Console.Write("How many points will you get as a completion bonus: ");
        _completionBonus = int.Parse(Console.ReadLine());
    }
    public ChecklistGoal(string title, string description, int pointValue, int countGoal, int completionBonus) : base(title, description, pointValue)
    {
        _countGoal = countGoal;
        _completionBonus = completionBonus;
    }
    public ChecklistGoal(string title, string description, int timesCompleted, bool completed, int pointValue, int countGoal, int completionBonus) : base(title, description, timesCompleted, pointValue)
    {
        _completed = completed;
        _countGoal = countGoal;
        _completionBonus = completionBonus;
    }
    
    public override int Bump()
    {
        if (!_completed)
        {
            _timesCompleted++;
            if (_timesCompleted == _countGoal)
            {
                _completed = true;
                return _completionBonus;
            }
            else
            {
                return _pointValue;
            }
        }
        else
        {
            return 0;
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"(Checklist) {_title}: {_description} | Completed {_timesCompleted}/{_countGoal} times | Worth {_pointValue} points each, {_completionBonus} point bonus.");
    }

    public override string GetSaveLine()
    {
        return $"Checklist#{_title}#{_description}#{_timesCompleted}#{_completed.ToString()}#{_pointValue}#{_countGoal}#{_completionBonus}";
    }

}