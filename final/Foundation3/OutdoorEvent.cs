using System;

public class OutdoorEvent : Event
{
    private string _weatherInfo;

    public OutdoorEvent(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {   
        _eventType = "Outdoor";
        _weatherInfo = weather;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("---Full Details---");
        Console.WriteLine($"Event type: {_eventType}\nTitle: {_title}\n{_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GetStringAddress()}\nWeather: {_weatherInfo}\n");
    }
}