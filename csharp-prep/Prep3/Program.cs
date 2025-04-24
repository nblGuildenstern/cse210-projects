using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        int guess;
        int guessCount;
        int answer;
        
        while(play) {
            guess = 0;
            guessCount = 0;
            Console.Write("What is the magic number? ");
            answer = int.Parse(Console.ReadLine());
            while (guess != answer) {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if(guess != answer) {
                    string response = answer > guess ? "Higher" : "Lower";
                    System.Console.WriteLine(response);
                }
            }
            string pluralality = guessCount > 1? "guesses" : "guess";
            System.Console.WriteLine($"\nCongratulations! It took you {guessCount} {pluralality}.");
            System.Console.Write("Do you want to play again?(y/n) ");
            play = Console.ReadLine().Trim().ToLower() == "y";
            System.Console.WriteLine("");
        }
        System.Console.WriteLine("Thanks for playing!");
    }
}