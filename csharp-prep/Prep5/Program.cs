using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult();
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
        System.Console.Write("Enter your username: ");
        int username = int.Parse(Console.ReadLine());
        return username;
    }
    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static void SquareNumber() {

    }
    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult() {

    }
}