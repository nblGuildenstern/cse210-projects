public class Word
{
    private string _word;
    private bool _isActive;

    public Word()
    {
        
    }
    public Word(string word)
    {
        _word = word;
        _isActive = true;
    }

    public void SetInactive()
    {
        _isActive = false;
    }

    public bool CheckActive()
    {
        return _isActive;
    }

    public string GetWord()
    {
        if (_isActive)
        {
            return _word;
        }
        else
        {
            char[] wordAsChar = _word.ToCharArray();
            for (int i = 0; i < wordAsChar.Length; i++)
            {
                wordAsChar[i] = '_';
            }
            string newWord = new string(wordAsChar);
            return newWord;
        }
    }
}