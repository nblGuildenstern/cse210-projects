public class Reflection : Activity
{

    private string[] _prompts = {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };
    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection() : base("Reflection",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    public override void RunActivity()
    {
        Random random = new Random();
        _endTime = DateTime.Now.AddSeconds(_duration);
        System.Console.WriteLine(_prompts[random.Next(_prompts.Length-1)]);
        DisplaySpinner(10);
        while (DateTime.Compare(DateTime.Now, _endTime) < 0)
        {
            System.Console.WriteLine(_questions[random.Next(_questions.Length - 1)]);
            DisplaySpinner(7);
        }
    }
}