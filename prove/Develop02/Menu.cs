public static class Menu
{

    public static void DisplayOptions()
    {
        Console.Clear();
        Console.WriteLine("Welcome to your journal editor! What would you like to do?");
        Console.WriteLine("1. Open Journal");
        Console.WriteLine("2. Create new Journal");
        Console.WriteLine("0. Quit");
        Console.WriteLine("");
    }

    public static void JournalOptions()
    {
        Console.Clear();
        Console.WriteLine("1. New Journal Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Close Journal");
        Console.WriteLine("0. Quit");
        Console.WriteLine("");
    }
    
    public static string SelectJournal()
    {
        string[] journals = Directory.GetFiles("journals");
        for (int i = 0; i < journals.Length; i++)
        {
            journals[i] = journals[i].Replace("journals\\", "").Replace("_", " ").Replace(".txt", "");
            Console.WriteLine($"{i + 1}. {journals[i]}");
        }
        return journals[int.Parse(Console.ReadLine()) - 1];
    }
}