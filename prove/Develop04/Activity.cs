using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    protected DateTime _endTime;

    public Activity()
    {

    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name.ToLower()} activity. {_description}");
        while (_duration == 0)
        {
            Console.Write("How long, in seconds, would you like for your session? ");

            try
            {
                _duration = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid input, please enter a valid time in seconds.\n");
            }
        }
    }

    public virtual void RunActivity()
    {

    }

    public void DisplaySpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("—");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.Write("\b \b");
    }
    
    public void DisplayOutro() {
        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.\n");
    }
}