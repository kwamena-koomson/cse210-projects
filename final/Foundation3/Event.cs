using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public void SetAddress(string street, string city, string stateOrProvince, string country)
    {
        _address = new Address(street, city, stateOrProvince, country);
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine("---Standard Details---");
        Console.WriteLine($"Event: {_title}\n{_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GetStringAddress()}\n");
    }

    public void DisplayShortDption()
    {
        Console.WriteLine("---Short Description---");
        Console.WriteLine($"Event type: {_eventType}\nEvent: {_title}\nDate: {_date}\n");
    }
}