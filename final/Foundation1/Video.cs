public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public void DisplayVideo()
    {
        int hours = (int)Math.Floor((double)_length / 3600);
        int minutes = (int)Math.Floor((double)(_length - hours * 3600) / 60);
        int seconds = _length % 60;
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {hours}:{minutes}:{seconds}");
        foreach (Comment comment in _comments)
        {
            Console.Write("\t");
            comment.DisplayComment();
        }
    }
}