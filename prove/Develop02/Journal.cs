public class Journal
{
    private string _fileName;
    public EntryManagement _entry = new EntryManagement();


    public void LoadFromFile()
    {
        GetFileName();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entrytext = parts[2];


            _entry.CreateEntryWithData(date, question, entrytext);
        }
    }
    public void SaveToFile()
    {
        GetFileName();

        using (StreamWriter journalFile = new StreamWriter(_fileName))
        {
            foreach (JournalEntry entry in _entry._entries)
            {
                journalFile.WriteLine($"{entry._date}#{entry._question}#{entry._entryText}");
            }
        }
    }

    private void GetFileName()
    {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        _fileName = fileName;
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry entry in _entry._entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._question}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine("");
        }
    }

}