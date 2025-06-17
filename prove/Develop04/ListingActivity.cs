class ListingActivity : BaseActivity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description)
    : base(name, description)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?", "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
        };
    }

    public void RunListingActivity()
    {
        DisplayIntro();

        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(0, _prompts.Count - 1);

        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($"---{_prompts[randomPrompt]}---\n");

        RunCountDown("You may begin in: ", 5);

        int counter = 0;
        StartTime();
        while (!HasTimerExpired())
        {
            Console.Write(">");
            Console.ReadLine();
            counter++;
        }

        DisplaySpinner($"\nYou listed {counter} items!", 5);

        DisplayAutro();
    }
}