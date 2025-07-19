public static class Menu
{

    public static void DisplayOptions()
    {
        Console.WriteLine("Welcome to your Eternal Quest! What would you like to do?");
        Console.WriteLine("1. Open User");
        Console.WriteLine("2. Create New User");
        Console.WriteLine("0. Quit");
        Console.WriteLine("");
    }

    public static void UserOptions()
    {
        Console.WriteLine("1. New Goal");
        Console.WriteLine("2. Display Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Delete Goal");
        Console.WriteLine("5. Switch User");
        Console.WriteLine("0. Quit");
        Console.WriteLine("");
    }

    public static void GoalOptions()
    {
        Console.WriteLine("What kind of goal?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("0. Cancel");
        Console.WriteLine("");
    }
    
    public static string GetUserFile()
    {
        string[] users = Directory.GetFiles("users");
        if (users.Length == 0)
        {
            Console.Clear();
            Console.WriteLine("No users to choose from. Please create a user first.");
            return null;
        }
        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {users[i].Replace("users\\", "").Replace("_", " ").Replace(".txt", "")}");
        }
        Console.WriteLine("");
        return users[int.Parse(Console.ReadLine()) - 1];
    }
}