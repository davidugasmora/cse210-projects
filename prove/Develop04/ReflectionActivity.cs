class ReflectionActivity : BaseActivity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string name, string description)
    : base(name, description)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
            "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
        };
    }

    public void RunReflectionActivity()
    {
        DisplayIntro();

        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(0, _prompts.Count - 1);

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"---{_prompts[randomPrompt]}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        RunCountDown("You may begin in: ", 5);

        StartTime();
        while (!HasTimerExpired())
        {
            int randomQuestion = randomGenerator.Next(0, _questions.Count - 1);
            DisplaySpinner(_questions[randomQuestion], 15);
        }

        DisplayAutro();
    }
}