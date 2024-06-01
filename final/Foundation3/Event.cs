public class Event
{
    // Protected member variables to hold event details
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    public Address _address;

    // Constructor to initialize the event details
    public Event(string eventType, string eventTitle, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Method to return standard event details as a string
    public string StandardDetails()
    {
        return $"Standard Event Details:\n" +
               $"Title: {_eventTitle}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date}\n" +
               $"Time: {_time}\n" +
               $"Address:\n{_address.GetAddressDetails()}";
    }

    // Virtual method to return full event details as a string
    public virtual string FullDetails()
    {
        return $"{StandardDetails()}";
    }

    // Method to return a short description of the event as a string
    public string ShortDescription()
    {
        return $"Short Description:\nEvent Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}";
    }
}
