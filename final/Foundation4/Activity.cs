using System;

public abstract class Activity
{
    protected string _activity;
    private string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Abstract methods to be implemented by derived classes
    protected abstract double CalculateDistance();
    protected abstract double CalculateSpeed();
    protected abstract double CalculatePace();
    
    // Method to get a summary of the activity
    public void GetSummary()
    {
        // Printing the summary of the activity.
        Console.WriteLine($"{_date} {_activity} ({_duration} min) - Distance: {CalculateDistance().ToString("F2")} km, Speed: {CalculateSpeed().ToString("F2")} kph, Pace: {CalculatePace().ToString("F2")} min per km");
    }
}