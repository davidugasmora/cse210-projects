class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status)
    {

    }

    public SimpleGoal()
    {
        SetName("");
        SetDescription("");
        SetPoints(0);
        SetStatus(false);
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
        if (!GetStatus())
        {
            SetStatus(true);
            Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
            return GetPoints();
        }
        else
        {
            Console.WriteLine("\nGoal already finished.");
            return 0;
        }
    }
}