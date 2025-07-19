using System;

class Program
{
    private static User user;
    static void Main(string[] args)
    {
        Console.Clear();
        int option = -1;
        do {
            if(user == null) {
                Menu.DisplayOptions();
                option = int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1: // Open User
                        Console.Clear();
                        Console.WriteLine("Which User would you like to view?");
                        user = new User();
                        user.LoadInfo(Menu.GetUserFile());
                        Console.Clear();
                        break;
                    case 2: // Create New User
                        Console.Clear();
                        Console.Write("Enter a name for the new user: ");
                        string userName = Console.ReadLine();
                        CreateUser(userName);
                        Console.Clear();
                        break;
                    case 0: // Quit Program
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } else {
                Console.WriteLine(user.GetInfo());
                Menu.UserOptions();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: // New entry
                        Console.Clear();
                        user.CreateGoal();
                        break;
                    case 2: // List goals
                        Console.Clear();
                        user.ListGoals();
                        Console.WriteLine("----------------------");
                        break; 
                    case 3: // Record Event
                        Console.Clear();
                        user.RecordEvent();
                        Console.WriteLine("----------------------");    
                        break; 
                    case 4: // Delete Goal
                        Console.Clear();
                        user.DeleteGoal();
                        Console.WriteLine("----------------------");    
                        break;
                    case 5: // Swtich users
                        Console.Clear();
                        SwitchUser();
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

    private static void CreateUser(string name)
    {
        user = new User(name);
        user.SaveInfo();
    }

    private static void SwitchUser()
    {
        user = null;
    }
}