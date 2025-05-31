using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = Menu.GetScripture();
        Console.Clear();
        bool allWordsInactive = false;
        while (!allWordsInactive)
        {
            allWordsInactive = scripture.DisplayScripture();
            if (Console.ReadLine() == "quit")
            {
                return;
            }
        }
        Console.Clear();
        scripture.DisplayScripture();
        Console.ReadLine();
    }
}