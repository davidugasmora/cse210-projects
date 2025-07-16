class Cycling : Activity
{
    private float _activitySpeed;

    public Cycling(string activityDate, int activityMinutes, float activitySpeed)
    : base(activityDate, activityMinutes)
    {
        _activitySpeed = activitySpeed;
    }

    public override float GetDistance()
    {
        return (_activitySpeed * GetMinutes()) / 60f;
    }

    public override float GetSpeed()
    {
        return _activitySpeed;
    }

    public override float GetPace()
    {
        return 60f / _activitySpeed;
    }
}