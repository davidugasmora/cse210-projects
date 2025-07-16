class Swimming : Activity
{
    private int _activityNumberLaps;

    public Swimming(string activityDate, int activityMinutes, int activityNumberLaps)
    : base(activityDate, activityMinutes)
    {
        _activityNumberLaps = activityNumberLaps;
    }

    public override float GetDistance()
    {
        return _activityNumberLaps * 50f / 1000f * 0.62f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60f;
    }

    public override float GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}