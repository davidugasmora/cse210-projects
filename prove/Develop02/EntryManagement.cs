public class EntryManagement
{
    private Questions _entryQuestions = new Questions();
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void CreateEntryWithPrompt()
    {
        string date = DateTime.Now.ToShortDateString();
        string question = _entryQuestions.GetRandomQuestion();

        Console.WriteLine($"{question}");
        Console.Write("> ");
        string entryText = Console.ReadLine();

        JournalEntry myJournalEntry = new JournalEntry(date, question, entryText);
        _entries.Add(myJournalEntry);
    }

    public void CreateEntryWithData(string date, string question, string entryText)
    {
        JournalEntry myJournalEntry = new JournalEntry(date, question, entryText);
        _entries.Add(myJournalEntry);
    }

}