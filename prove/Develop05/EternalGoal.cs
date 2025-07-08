class EternalGoal : Goal
{
    private int _numberOfCompletions;

    public EternalGoal(string name, string description, int points, bool status, int numberOfCompletions)
    : base(name, description, points, status)
    {
        _numberOfCompletions = numberOfCompletions;
    }

    public EternalGoal()
    {
        SetName("");
        SetDescription("");
        SetPoints(0);
        SetStatus(false);
        _numberOfCompletions = 0;
    }

    public override int GetNumberOfCompletions()
    {
        return _numberOfCompletions;
    }

    public override void RunGoal()
    {
        Console.Write("\nWhat is the name of the goal you want to create: ");
        string name = Console.ReadLine();
        SetName(name);

        Console.Write("\nWhat is a short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);

        SetPoints(ValidateInt("What is the amount of points associated with this goal? "));
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
        ++_numberOfCompletions;
        return GetPoints();
    }
}