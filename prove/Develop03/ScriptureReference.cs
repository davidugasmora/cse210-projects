class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[1];
        _verse[0] = verse;
    }
    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[2];
        _verse[0] = startVerse;
        _verse[1] = endVerse;
    }

    public string GetScriptureReference()
    {
        string verseList = string.Join("-", _verse);
        string referenceString = $"{_bookName} {_chapter}: {verseList}";

        return referenceString;
    }
}