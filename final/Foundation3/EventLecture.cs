class EventLecture : Event
{
    private string _eventSpeaker;
    private int _eventCapacity;

    public EventLecture(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string eventSpeaker, int eventCapacity)
    : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _eventSpeaker = eventSpeaker;
        _eventCapacity = eventCapacity;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Speaker:    {_eventSpeaker}");
        Console.WriteLine($"Capacity:   {_eventCapacity}");
    }
}