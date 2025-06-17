class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description)
    : base(name, description)
    {

    }

    public void RunBreathingActivity()
    {
        DisplayIntro();

        int breathSeconds = 5;

        StartTime();
        while (!HasTimerExpired())
        {
            RunCountDown("Breath in...", breathSeconds);
            RunCountDown("Now breath out...", breathSeconds);
            Console.WriteLine();
        }

        DisplayAutro();
    }
}