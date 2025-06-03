class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public bool IsHidden()
    {
        _hidden = _word.All(letter => letter == '_');

        return _hidden;
    }

    public void ConvertToHidden()
    {
        _word = new string('_', _word.Length);
    }

    public string GetWord()
    {
        return _word;
    }
}