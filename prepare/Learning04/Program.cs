using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Kryton Bess", "Multiplication");
        Math math = new Math("Kryton Bess", "Fractions", "Section 7.3", "8-19");
        Writing writing = new Writing("Kryton Bess", "European History", "The Causes of World War II");

        assignment.GetSummary();
        Console.WriteLine();
        math.GetSummary();
        math.GetHomeworkList();
        Console.WriteLine();
        writing.GetSummary();
        writing.GetWritingInformation();
    }
}