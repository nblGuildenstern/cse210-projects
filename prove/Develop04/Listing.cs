public class Listing : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing() : base("Listing",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    public override void RunActivity()
    {
        Random random = new Random();
        _endTime = DateTime.Now.AddSeconds(_duration);
        System.Console.WriteLine(prompts[random.Next(prompts.Length - 1)]);
        int count = 1;
        while (DateTime.Compare(DateTime.Now, _endTime) < 0)
        {
            Console.Write(count + ". ");
            Console.ReadLine();
            count++;
        }
    }
}