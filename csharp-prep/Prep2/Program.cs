using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercent = int.Parse(Console.ReadLine());

        string grade = "";

        if(gradePercent >= 90) {
            grade = "A";
        }
        else if(gradePercent >= 80) {
            grade = "B";
        }
        else if(gradePercent >= 70) {
            grade = "c";
        }
        else if(gradePercent >= 60) {
            grade = "D";
        }
        else {
            grade = "F";
        }

        string message = gradePercent >= 70 ? "Congratulations on passing!" : "You failed the class! Try again next semester.";

        System.Console.WriteLine($"Final grade in the class: {grade}");
        System.Console.WriteLine(message);
        
    }
}