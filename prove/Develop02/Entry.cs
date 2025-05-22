public class Entry {
    public string _prompt;
    public string _answer;
    public string _dateText;
    DateTime theCurrentTime = DateTime.Now;

    public Entry()
    {
        _prompt = Questions.GetQuestion();
        System.Console.WriteLine(_prompt);
        _answer = Console.ReadLine();
        _dateText = theCurrentTime.ToShortDateString();
    }
    public Entry(string line)
    {
        string[] parts = line.Split("#");

        _prompt = parts[0];
        _answer = parts[1];
        _dateText = parts[2];
    }

    public void DisplayEntry()
    {
        Console.WriteLine(_dateText);
        Console.WriteLine(_prompt);
        Console.WriteLine(_answer);
    }
}