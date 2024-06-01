using System;

public class Running : Activity
{
    private double _distance;

    // Constructor to initialize running activity with date, duration, and distance
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _activity = "Running"; 
        _distance = distance; 
    }

    // Method to calculate the distance covered during running activity
    protected override double CalculateDistance()
    {
        return _distance; 
    }

    // Method to calculate the pace (minutes per kilometer) during running activity
    protected override double CalculatePace()
    {
        return 60 / CalculateSpeed(); 
    }

    // Method to calculate the speed (kilometers per hour) during running activity
    protected override double CalculateSpeed()
    {
        return (_distance / _duration) * 60; 
    }
}
