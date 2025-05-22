using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    private string dir = "journals/";
    public string _name;
    private List<Entry> _entries = new List<Entry>();

    public Journal(string name)
    {   
        string filename = dir + name.Replace(" ", "_") + ".txt";
        System.Console.WriteLine(filename);
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                _entries.Add(new Entry(line));
            }
            _name = name;
        }
        catch
        {
            _name = name;
            StreamWriter outputFile = new StreamWriter(filename);
            System.Console.WriteLine("File created!");
        }
    }

    public void AddEntry()
    {
        _entries.Add(new Entry());
        SaveJournal();
    }

    public void DisplayJournal()
    {
        Console.Clear();
        System.Console.WriteLine("Journal: " + _name + " (press enter to exit)");
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.ReadLine();
    }

    public void SaveJournal()
    {
        string filename = dir + _name.Replace(" ", "_") + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._prompt}#{entry._answer}#{entry._dateText}");
            }
        }
    }
}