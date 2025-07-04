using System.Drawing;

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
        _name = "";
        _description = "";
        _points = 0;
        _status = false;
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

    public abstract void RunGoal();
    public abstract int RecordEvent();
}