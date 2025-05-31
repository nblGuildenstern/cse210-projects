using System.Text.Json;


public class Quad
{
    private List<Section> sections = new List<Section>();
    private string book;
    private int chapter;
    private int[] verses;
    private Reference reference;
    public Quad()
    {
        string jsonString = File.ReadAllText("sections/new-testament.json");
        sections.Add(JsonSerializer.Deserialize<Section>(jsonString));

        jsonString = File.ReadAllText("sections/old-testament.json");
        sections.Add(JsonSerializer.Deserialize<Section>(jsonString));

        jsonString = File.ReadAllText("sections/book-of-mormon.json");
        sections.Add(JsonSerializer.Deserialize<Section>(jsonString));

        jsonString = File.ReadAllText("sections/doctrine-and-covenants.json");
        sections.Add(JsonSerializer.Deserialize<Section>(jsonString));

        jsonString = File.ReadAllText("sections/pearl-of-great-price.json");
        sections.Add(JsonSerializer.Deserialize<Section>(jsonString));
    }

    public Scripture GetScripture()
    {
        Section section = GetSection();
        Verse verse;
        if (section.books[0].book == "D&C")
        {
            verse = GetDCSection();
        }
        else
        {
            verse = GetBook(section);
        }
        return new Scripture(verse.text, reference);
    }

    private Section GetSection()
    {
        Console.Clear();
        Console.WriteLine("Select which section:");
        Console.WriteLine("1. Old Testament");
        Console.WriteLine("2. New Testament");
        Console.WriteLine("3. Book of Mormon");
        Console.WriteLine("4. Doctrine and Covenants");
        Console.WriteLine("5. Pearl of Great Price");
        return sections[int.Parse(Console.ReadLine()) - 1];
    }

    private Verse GetBook(Section section)
    {
        Console.Clear();
        System.Console.WriteLine("Select a book: ");
        for (int i = 0; i < section.books.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {section.books[i].book}");
        }
        int selection = int.Parse(Console.ReadLine()) - 1;
        book = section.books[selection].book;
        return GetChapter(section.books[selection]);
    }

    private Verse GetChapter(Book book)
    {
        Console.Clear();
        Console.WriteLine($"Select Chapter(1-{book.chapters.Count})");
        chapter = int.Parse(Console.ReadLine()) - 1;
        return GetVerses(book.chapters[chapter]);
    }

    private Verse GetDCSection()
    {
        Console.Clear();
        System.Console.WriteLine("Select Section(1-138)");
        chapter = int.Parse(Console.ReadLine()) - 1;
        return GetVerses(sections[3].books[0].chapters[chapter]);
    }

    private Verse GetVerses(Chapter chapter)
    {
        // for (int i = 0; i < chapter.verses.Count; i++)
        // {
        //     System.Console.WriteLine($"{i+1}. {chapter.verses[i].text}");
        // }
        Console.Clear();
        Console.Write($"Select Verse(1-{chapter.verses.Count}): ");
        return chapter.verses[int.Parse(Console.ReadLine()) - 1];
    }
}

public class Section
{
    public List<Book> books { get; set; }
}

public class Book
{
    public string book { get; set;}
    public List<Chapter> chapters { get; set;}
}

public class Chapter
{
    public int chapter { get; set;}
    public string reference { get; set;}
    public List<Verse> verses { get; set;}
}

public class Verse
{
    public string reference { get; set;}
    public string text { get; set;}
    public int verse { get; set;}
}