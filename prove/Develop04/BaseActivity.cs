class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"\nThis activity will help you {_description}");

        GetDuration();

        int spinnerSeconds = 5;
        string readySpinnerMessage = "Get ready...";
        DisplaySpinner(readySpinnerMessage, spinnerSeconds);
        Console.WriteLine("\n");
    }
    private void GetDuration()
    {
        bool done = false;

        while (!done)
        {
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out _duration) && _duration > 0)
            {
                done = true;
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.\n");
            }
        }
    }
    public void DisplayAutro()
    {
        int spinnerSeconds = 5;
        string doneSpinnerMessage = "Well done!!";
        DisplaySpinner(doneSpinnerMessage, spinnerSeconds);
        Console.WriteLine();
        string completedSpinnerMessage = $"You have completed another {_duration} seconds of the {_name} Activity.";
        DisplaySpinner(completedSpinnerMessage, spinnerSeconds);
    }
    public void RunCountDown(string message, int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds + 1);

        Console.Write(message);
        while (DateTime.Now < endTime)
        {
            Console.Write(seconds--);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void DisplaySpinner(string message, int seconds)
    {

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        string animationStringLoad = "-\\|/";
        int index = 0;

        Console.Clear();
        Console.WriteLine(message);
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStringLoad[index++ % animationStringLoad.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }
    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }
}