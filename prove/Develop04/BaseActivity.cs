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

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
    }
    public void DisplayDescription()
    {
        Console.WriteLine($"This activity will help you {_description}");
    }
    public void getDuration()
    {
        bool done = false;

        while (!done)
            Console.Write("How long, in seconds, would you like for your session?");

            if (int.TryParse(Console.ReadLine(), out _duration))
            {
                done = true;
            }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.\n");
        }
    }
    public void DisplayEnding()
    {
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }
    public void RunCountDown(string message, int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{message}{seconds--}");
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
    public void DisplaySpinner(string message, int seconds)
    {

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        string animationStringLoad = "-\\|/";
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"{message}{animationStringLoad[index++ % animationStringLoad.Length]}");
            Thread.Sleep(250);
            Console.Write("\b");
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