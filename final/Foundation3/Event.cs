class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _eventAddress;
    private string _eventType;

    public Event(string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public string GetEventType()
    {
        _eventType = this.GetType().Name;
        return _eventType;
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine($"\nType:       {GetEventType()}");
        Console.WriteLine(  $"Title:      {_eventTitle}");
        Console.WriteLine(  $"Date:       {_eventDate}");
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"\nTitle:      {_eventTitle}");
        Console.WriteLine(  $"Descrition: {_eventDescription}");
        Console.WriteLine(  $"Date:       {_eventDate}");
        Console.WriteLine(  $"Time:       {_eventTime}");
        Console.WriteLine(  $"Adress:     {_eventAddress.GetAddress()}");
    }

    public virtual void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine(  $"Type:       {GetEventType()}");
    }
}