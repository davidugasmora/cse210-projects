public class JournalEntry
{
    public string _date;
    public string _question;
    public string _entryText;

    public JournalEntry(string date, string question, string entryText)
    {
        _date = date;
        _question = question;
        _entryText = entryText;
    }
}