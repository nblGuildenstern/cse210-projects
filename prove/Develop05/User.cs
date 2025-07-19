public class User
{
    private string _name;
    private int _points;
    private List<Goal> _goals = new List<Goal>();

    private string dir = "users/";
    public User()
    {
        _points = 0;
    }
    public User(string name)
    {
        _name = name;
        _points = 0;
    }
    public string GetInfo()
    {
        return $"{_name}: {_points} points";
    }

    public void CreateGoal()
    {
        int option = -1;
        do
        {
            Console.Clear();
            Menu.GoalOptions();
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: // Simple Goal
                    _goals.Add(new SimpleGoal());
                    Console.Clear();
                    SaveInfo();
                    return;
                case 2: // Checklist Goal
                    _goals.Add(new ChecklistGoal());
                    Console.Clear();
                    SaveInfo();
                    return;
                case 3: // Eternal Goal
                    _goals.Add(new EternalGoal());
                    Console.Clear();
                    SaveInfo();
                    return;
                case 0:
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option");
                    break;
            }
        } while (option != 0);
    }
    public void ListGoals()
    {
        bool allCompleted = true;
        foreach (Goal goal in _goals)
        {
            if (!goal.IsCompleted())
            {
                allCompleted = false;
                goal.DisplayGoal();
            }
        }
        if (allCompleted)
        {
            Console.Clear();
            Console.WriteLine("No incomplete goals to list.");
            return;
        }
    }

    public void RecordEvent()
    {
        bool allCompleted = true;
        int completedGoalsCount = 0;
        Console.WriteLine("Your goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i].IsCompleted())
            {
                completedGoalsCount++;
                continue; 
            }
            allCompleted = false;
            Console.Write($"{i + 1 - completedGoalsCount}. ");
            _goals[i].DisplayGoal();
        }
        if (allCompleted)
        {
            Console.Clear();
            Console.WriteLine("No incomplete goals to record events for.");
            return;
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        int points = _goals[choice - 1 + completedGoalsCount].Bump();
        AddPoints(points);
        SaveInfo();

        Console.Clear();
        Console.WriteLine($"Event recorded! Earned {points} points.");
    }
    private void AddPoints(int points)
    {
        _points += points;
    }
    public void DeleteGoal()
    {
        if (_goals.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("No goals to delete.");
            return;
        }
        Console.WriteLine("Your goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
        Console.Write("Which goal do you want to delete? ");
        int choice = int.Parse(Console.ReadLine());
        try
        {
            _goals.RemoveAt(choice - 1);
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }
        SaveInfo();

            Console.Clear();
        Console.WriteLine("Goal successfully deleted");
    }
    public void SaveInfo()
    {
        string filename = dir + _name.Replace(" ", "_") + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_name}#{_points}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveLine());
            }
        }
    }
    public void LoadInfo(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        _name = lines[0].Split("#")[0];
        _points = int.Parse(lines[0].Split("#")[1]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("#");
            switch (parts[0])
            {
                case "Simple":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4] == "True", int.Parse(parts[5])));
                    break;
                case "Checklist":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4] == "True", int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                    break;
                case "Eternal":
                   _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4])));
                    break;
                default:
                    break;
            }
        }
    }
}