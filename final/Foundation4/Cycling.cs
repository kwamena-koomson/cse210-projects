using System;

public class Cycling : Activity
{
    private double _speed;


    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _activity = "Cycling"; 
        _speed = speed; 
    }

    // Method to calculate the distance covered during cycling
    protected override double CalculateDistance()
    {
        // Calculating distance using speed and duration
        return _speed * (_duration / 60D); 
    }

    // Method to calculate the pace (time per unit distance) during cycling
    protected override double CalculatePace()
    {
        // Calculating pace (minutes per kilometer) using speed
        return 60 / _speed; 
    }

    // Method to calculate the speed during cycling
    protected override double CalculateSpeed()
    {
        return _speed; 
    }
}
