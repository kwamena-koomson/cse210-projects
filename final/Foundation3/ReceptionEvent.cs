using System;

public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, string email) : base(title, description, date, time)
    {
        _eventType = "Reception";
        _email = email;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("---Full Details---");
        Console.WriteLine($"Event type: {_eventType}\nTitle: {_title}\n{_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GetStringAddress()}\nPlease RSVP: {_email}\n");
    }
}