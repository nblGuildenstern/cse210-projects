public class Breathing : Activity
{

    public Breathing() : base("Breathing",
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public override void RunActivity()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Compare(DateTime.Now, _endTime) < 0)
        {
            System.Console.WriteLine("Breathe in...");
            DisplaySpinner(4);
            System.Console.WriteLine("Breathe out...");
            DisplaySpinner(4);
        }
    }
}