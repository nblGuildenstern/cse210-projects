using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =
        [
            new Running("12 Feb 2025", 30, 3),
            new Cycling("15 Feb 2025", 30, 10),
            new Swimming("24 Feb 2025", 30, 4),
        ];

        foreach (Activity activity in activities)
        {
            activity.PrintSummary();
        }
    }
}