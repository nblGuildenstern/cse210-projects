public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public Scripture()
    {

    }
    public Scripture(Reference reference)
    {

    }
    public Scripture(string text, Reference reference)
    {
        SetWords(text);
        _reference = reference;
    }

    private void SetWords(string text)
    {
        string[] wordList = text.Split(" ");
        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }
    public bool DisplayScripture()
    {
        Console.Clear();
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
        return RemoveWords();  
    }

    public bool RemoveWords()
    {
        List<int> activeWords = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].CheckActive())
            {
                activeWords.Add(i);
            }
        }
        Random random = new Random();
        if (activeWords.Count == 0)
        {
            return true;
        }
        else if (activeWords.Count > 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int num = random.Next(0, activeWords.Count);
                _words[activeWords[num]].SetInactive();
                activeWords.Remove(num);
            }
        }
        else
        {
            foreach (int i in activeWords)
            {
                _words[i].SetInactive();
            }
        }
        return false;
    }
}