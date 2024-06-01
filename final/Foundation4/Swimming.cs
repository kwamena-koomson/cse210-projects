using System;

public class Swimming : Activity
{   
    private int _laps;

    // Constructor to initialize swimming activity with date, duration, and laps
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _activity = "Swimming"; 
        _laps = laps; 
    }

    // Method to calculate the distance covered during swimming activity
    protected override double CalculateDistance()
    {
        // Each lap is 50 meters, so total distance is laps * 50 meters, converted to kilometers
        return (_laps * 50) / 1000D;
    }

    // Method to calculate the pace (minutes per kilometer) during swimming activity
    protected override double CalculatePace()
    {
        // Pace is calculated by dividing duration by distance
        return _duration / CalculateDistance();
    }

    // Method to calculate the speed (kilometers per hour) during swimming activity
    protected override double CalculateSpeed()
    {
        // Speed is the inverse of pace (minutes per kilometer), converted to hours
        return 60 / CalculatePace();
    }
}
