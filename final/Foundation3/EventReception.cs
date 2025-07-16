class EventReception : Event
{
    private string _eventEmail;

    public EventReception(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress, string eventEmail)
    : base(eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _eventEmail = eventEmail;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Email:      {_eventEmail}");
    }
}