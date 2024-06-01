using System;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {   
        _eventType = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("---Full Details---");
        Console.WriteLine($"Event type: {_eventType}\nTitle: {_title}\n{_description}\nSpeaker: {_speaker}\nDate: {_date} Time: {_time}\nAddress: {_address.GetStringAddress()}\nCapacity: {_capacity}\n");
    }
}