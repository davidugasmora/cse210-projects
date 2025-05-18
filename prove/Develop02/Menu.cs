public class Menu
{
    private Journal myJournal = new Journal();
    public void DisplayMenu()
    {
        Console.WriteLine("Journal Program");

        while (true)
        {
            DisplayMenuOptions();
            int menuChoice = GetInput();

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("New Journal Entry selected.");
                    myJournal._entry.CreateEntryWithPrompt();
                    break;
                case 2:
                    Console.WriteLine("Display Journal selected.");
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Read Journal from file selected.");
                    myJournal.LoadFromFile();
                    break;
                case 4:
                    Console.WriteLine("Write Journal to file selected.");
                    myJournal.SaveToFile();
                    break;
                case 5:
                    Console.WriteLine("Exiting the Journal Program...");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }

    }

    private void DisplayMenuOptions()
    {
        Console.WriteLine("Write, display, save, and load your journal.");
        Console.WriteLine("1. New Journal Entry.");
        Console.WriteLine("2. Display Journal.");
        Console.WriteLine("3. Read Journal from file.");
        Console.WriteLine("4. Write Journal to file.");
        Console.WriteLine("5. Quit Journal.");
    }

    private int GetInput()
    {
        int userInput;
        while (true)
        {
            Console.Write("> ");
            string strUserInput = Console.ReadLine();

            if (int.TryParse(strUserInput, out userInput) && userInput >= 1 && userInput <= 5)
            {
                return userInput;
            }

            Console.WriteLine("Invalid input, please enter a number between 1 and 5.");
        }
    }
}