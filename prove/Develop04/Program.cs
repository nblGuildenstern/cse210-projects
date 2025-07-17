using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Activity currentActivity = new Activity();
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        int option = -1;
        do
        {
            DisplayOptions();
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    currentActivity = new Breathing();
                    break;
                case 2:
                    currentActivity = new Reflection();
                    break;
                case 3:
                    currentActivity = new Listing();
                    break;
                case 4:
                    GetHistoryCount();
                    continue;
                case 0:
                    System.Console.WriteLine("Thanks for using the Mindfulness Program!");
                    continue;
                default:
                    Console.Clear();
                    System.Console.WriteLine("Invalid Option");
                    continue;
            }
            currentActivity.DisplayIntro();
            currentActivity.RunActivity();
            currentActivity.DisplayOutro();
            AddHistoryCount(option);
        } while (option != 0);
    }

    private static void DisplayOptions()
    {
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Display History");
        Console.WriteLine("0. Quit");
        Console.WriteLine("");
        Console.Write("What would you like to do? ");
    }
    private static int GetLength()
    {
        return 0;
    }

    private static void GetHistoryCount()
    {
        string filename = "history.txt";
        Console.Clear();
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch
        {
            StreamWriter outputFile = new StreamWriter(filename);
            Console.WriteLine("File created!");
        }
        System.Console.WriteLine();
    }
    private static void AddHistoryCount(int activityRow)
    {
        string filename = "history.txt";
        string[] lines = File.ReadAllLines(filename);
        lines[activityRow] = lines[activityRow].Split(": ")[0] + ": " + (int.Parse(lines[activityRow].Split(": ")[1]) + 1);
        File.WriteAllLines(filename, lines);
    }
}