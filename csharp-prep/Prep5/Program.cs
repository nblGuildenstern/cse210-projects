using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int num = PromptUserNumber();
        int sqNum = SquareNumber(num);
        DisplayResult(username, sqNum);
    }

    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome() {
        System.Console.WriteLine("Welcome to the Program!");
    }
    //Asks for and returns the user's name (as a string)
    static string PromptUserName() {
        System.Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        return username;
    }
    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber() {
        System.Console.Write("What is your favorite number? ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }
    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int num) {
        return num * num;
    }
    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string username, int num) {
        Console.WriteLine($"{username}, your favorite number squared is {num}");
    }
}