using System.Drawing;
using System.Dynamic;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;

    public Goal(string name, string description, int points, bool status)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        _status = status;
    }
    public Goal()
    {
        SetName("");
        SetDescription("");
        SetPoints(0);
        SetStatus(false);
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public void SetStatus(bool status)
    {
        _status = status;
    }

    public int ValidateInt(string question)
    {
        while (true)
        {
            Console.Write($"\n{question}");
            string strNumber = Console.ReadLine();

            if (int.TryParse(strNumber, out int Number))
            {
                return Number;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid input, please enter an integer");
            }
        }
    }

    public virtual int GetNumberOfCompletions()
    {
        return 0;
    }
    public virtual int GetMaxGoals()
    {
        return 0;
    }
    public virtual int GetBonusPoints()
    {
        return 0;
    }
    public string GetGoalType()
    {
        _goalType = this.GetType().Name;
        return _goalType;
    }
    public abstract void RunGoal();
    public abstract int RecordEvent();
}