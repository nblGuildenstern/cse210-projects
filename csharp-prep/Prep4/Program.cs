using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        List<int> numList = new List<int>();
        int addedNum = -1;
        int sum = 0;
        int largestNum = 0;

        while(addedNum != 0) {
            System.Console.Write("Enter number: ");
            addedNum = int.Parse(Console.ReadLine());
            if(addedNum == 0) break;
            numList.Add(addedNum);
            sum += addedNum;
            if(addedNum > largestNum) {
                largestNum = addedNum;
            }
        }
        double average = (double)sum / numList.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        
    }
}