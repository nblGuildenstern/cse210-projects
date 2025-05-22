using System;

class Program
{
    private static Journal journal;
    static void Main(string[] args)
    {
        int option = -1;
        do {
            if(journal == null) {
                Menu.DisplayOptions();
                option = int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1: // Open Journal
                        Console.Clear();
                        Console.WriteLine("Which Journal would you like to open?");
                        journal = new Journal(Menu.SelectJournal());
                        break;
                    case 2: // Create New Journal
                        Console.WriteLine("What would you like your journal to be called?");
                        string journalName = Console.ReadLine();
                        CreateJournal(journalName);
                        break;
                    case 0: // Quit Program
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } else {
                Menu.JournalOptions();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: // New entry
                        journal.AddEntry();

                        break;
                    case 2: // Display journal
                        journal.DisplayJournal();
                        break;
                    case 3: // Close Journal
                        CloseJournal();
                        break;
                    case 0: // Quit Program
                        break;
                    default:
                        System.Console.WriteLine("Not valid input");
                        break;
                }
            }


        } while(option != 0);
    }

    private static void CreateJournal(string name)
    {
        journal = new Journal(name);
    }

    private static void CloseJournal()
    {
        journal = null;
    }

}