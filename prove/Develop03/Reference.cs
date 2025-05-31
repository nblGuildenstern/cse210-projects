public class Reference
{
    private string _bookName;
    private int _chapter;
    private int[] _verses;

    public Reference()
    {

    }

    public Reference(string book, int chapter, int[] verses)
    {
        _bookName = book;
        _chapter = chapter;
        _verses = verses;
    }
}