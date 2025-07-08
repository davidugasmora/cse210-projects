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

        while (true)
        {
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            string strPoints = Console.ReadLine();

            if (int.TryParse(strPoints, out int points))
            {
                SetPoints(points);
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid input, please enter an integer");
            }
        }

    }
    public override int RecordEvent()
    {
        SetStatus(true);
        Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
        return GetPoints();
    }
}