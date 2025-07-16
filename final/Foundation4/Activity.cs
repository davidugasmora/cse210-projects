abstract class Activity
{
    private string _activityDate;
    private int _activityMinutes;
    private string _eventType;

    public Activity(string activityDate, int activityMinutes)
    {
        _activityDate = activityDate;
        _activityMinutes = activityMinutes;
    }

    public string GetActivityType()
    {
        _eventType = this.GetType().Name;
        return _eventType;
    }

    public float GetMinutes()
    {
        return _activityMinutes;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public string GetSummary()
    {
        return $"{_activityDate} {GetActivityType()} ({_activityMinutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}