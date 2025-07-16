class Running : Activity
{
    private float _activityDistance;

    public Running(string activityDate, int activityMinutes, float activityDistance)
    : base(activityDate, activityMinutes)
    {
        _activityDistance = activityDistance;
    }

    public override float GetDistance()
    {
        return _activityDistance;
    }

    public override float GetSpeed()
    {
        return (_activityDistance / GetMinutes()) * 60f;
    }

    public override float GetPace()
    {
        return GetMinutes() / _activityDistance;
    }


}