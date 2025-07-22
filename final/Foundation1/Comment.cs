using System.ComponentModel.DataAnnotations;

public class Comment
{
    private string _user;
    private string _text;

    public Comment()
    {

    }
    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_user}: {_text}");
    }
}