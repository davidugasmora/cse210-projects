using System.IO;

class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private string _fileName;
    private int _totalScore;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void SaveGoals()
    {
        ObtainFileName();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"Score#{_totalScore}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetGoalType()}#{goal.GetName()}#{goal.GetDescription()}#{goal.GetPoints()}#{goal.GetStatus()}");
            }
        }
    }

    public void LoadGoals()
    {
        ObtainFileName();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            if (parts.Length > 2)
            {
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                int goalPoints = int.Parse(parts[3]);
                bool goalStatus = bool.Parse(parts[4]);

                if (goalType == "SimpleGoal")
                {
                    SimpleGoal mySimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, goalStatus);
                    AddGoal(mySimpleGoal);
                }

            }
            else
            {
                _totalScore = int.Parse(parts[1]);
            }
            
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_totalScore} points.");
    }

    public void DisplayGoals()
    {
        int counter = 0;

        Console.WriteLine("\nThe goals are:");

        foreach (Goal goal in _goals)
        {
            string check = goal.GetStatus() ? "x" : " ";

            Console.WriteLine($"\n{++counter}. [{check}] {goal.GetName()} ({goal.GetDescription()})");
        }
    }

    public void RecordEvent()
    {
        Console.Write("\nWhich Goal did you accomplish? ");
        string strGoalIndex = Console.ReadLine();

        if (int.TryParse(strGoalIndex, out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            _totalScore += _goals[goalIndex - 1].RecordEvent();
            Console.WriteLine($"\nYou now have {_totalScore} points.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nInvalid input, please enter a number that correlates with the existing list of goals.");
        }
    }

    private void ObtainFileName()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        _fileName = Console.ReadLine();
    }
}