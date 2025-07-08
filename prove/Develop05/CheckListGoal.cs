class CheckListGoal : Goal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, bool status, int numberOfCompletions, int maxGoals, int bonusPoints)
    : base(name, description, points, status)
    {
        _numberOfCompletions = numberOfCompletions;
        _maxGoals = maxGoals;
        _bonusPoints = bonusPoints;
    }

    public CheckListGoal()
    {
        SetName("");
        SetDescription("");
        SetPoints(0);
        SetStatus(false);
        _numberOfCompletions = 0;
        _maxGoals = 0;
        _bonusPoints = 0;
    }

    public override int GetNumberOfCompletions()
    {
        return _numberOfCompletions;
    }
    public override int GetMaxGoals()
    {
        return _maxGoals;
    }
    public override int GetBonusPoints()
    {
        return _bonusPoints;
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
        _maxGoals = ValidateInt("How many times does this goal need to accomplished for a bonus? ");
        _bonusPoints = ValidateInt("What is the bonus for accomplishing it that many times? ");
    }

    public override int RecordEvent()
    {
        if (!GetStatus())
        {
            ++_numberOfCompletions;

            if (_numberOfCompletions == _maxGoals)
            {
                SetStatus(true);
                Console.WriteLine($"\nCongratulations! You have earned {GetPoints() + _bonusPoints} points!");
                return GetPoints() + _bonusPoints;
            }
            else
            {
                Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
                return GetPoints();
            }
        }
        else
        {
            Console.WriteLine("\nGoal already finished.");
            return 0;
        }
    }
}