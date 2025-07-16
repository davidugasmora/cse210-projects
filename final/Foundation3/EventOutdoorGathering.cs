class EventOutdoorGathering : Event
{
    private string _eventWeather;

    public EventOutdoorGathering(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string eventWeather)
    : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _eventWeather = eventWeather;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Weather:    {_eventWeather}");
    }
}