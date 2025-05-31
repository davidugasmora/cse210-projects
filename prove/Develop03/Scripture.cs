using System.Diagnostics.Metrics;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private ScriptureReference _reference;
    private Random _randomGenerator = new Random();

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(name, chapter, verse);
        ConvertTextToWords(text);
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse);
        ConvertTextToWords(text);
    }

    private void ConvertTextToWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word myWord = new Word(word);
            _words.Add(myWord);
        }
    }

    private int CountWordsToHide()
    {
        int visibleCount = _words.Count(word => !word.IsHidden());
        int wordsToHide = Math.Min(3, visibleCount);

        return wordsToHide;
    }

    public void HideSomeWords()
    {
        int wordsTohide = CountWordsToHide();

        if (wordsTohide == 0)
        {
            return;
        }

        int counter = 0;

        while (counter < wordsTohide)
        {
            int randomWord = _randomGenerator.Next(0, _words.Count);

            if (!_words[randomWord].IsHidden())
            {
                _words[randomWord].ConvertToHidden();
                counter++;
            }
        }
    }

    public void ShowScripture()
    {
        Console.Write($"{_reference.GetScriptureReference()} ");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
    }
}