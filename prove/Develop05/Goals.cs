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
                if (goal.GetGoalType() == "SimpleGoal")
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}#{goal.GetName()}#{goal.GetDescription()}#{goal.GetPoints()}#{goal.GetStatus()}");
                }
                else if (goal.GetGoalType() == "EternalGoal")
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}#{goal.GetName()}#{goal.GetDescription()}#{goal.GetPoints()}#{goal.GetStatus()}#{goal.GetNumberOfCompletions()}");
                }
                else if (goal.GetGoalType() == "CheckListGoal")
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}#{goal.GetName()}#{goal.GetDescription()}#{goal.GetPoints()}#{goal.GetStatus()}#{goal.GetNumberOfCompletions()}#{goal.GetMaxGoals()}#{goal.GetBonusPoints()}");
                }
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
                else if (goalType == "EternalGoal")
                {
                    int goalNumberOfCompletions = int.Parse(parts[5]);

                    EternalGoal myEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, goalStatus, goalNumberOfCompletions);
                    AddGoal(myEternalGoal);
                }
                else if (goalType == "CheckListGoal")
                {
                    int goalNumberOfCompletions = int.Parse(parts[5]);
                    int goalMaxGoals = int.Parse(parts[6]);
                    int goalBonusPoints = int.Parse(parts[7]);
                    CheckListGoal myCheckListGoal = new CheckListGoal(goalName, goalDescription, goalPoints, goalStatus, goalNumberOfCompletions, goalMaxGoals, goalBonusPoints);
                    AddGoal(myCheckListGoal);
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

            if (goal.GetGoalType() == "SimpleGoal")
            {
                Console.WriteLine($"\n{++counter}. [{check}] {goal.GetName()} ({goal.GetDescription()})");
            }
            else if (goal.GetGoalType() == "EternalGoal")
            {
                Console.WriteLine($"\n{++counter}. [{check}] {goal.GetName()} ({goal.GetDescription()}) -- Times completed: {goal.GetNumberOfCompletions()}");
            }
            else if (goal.GetGoalType() == "CheckListGoal")
            {
                Console.WriteLine($"\n{++counter}. [{check}] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {goal.GetNumberOfCompletions()}/{goal.GetMaxGoals()}");
            }

            
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.Write("\nWhich Goal did you accomplish? ");
        string strGoalIndex = Console.ReadLine();

        if (int.TryParse(strGoalIndex, out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            _totalScore += _goals[goalIndex - 1].RecordEvent();
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