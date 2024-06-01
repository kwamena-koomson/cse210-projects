using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _activity = "Running";
        _distance = distance;
    }
    protected override double CalculateDistance()
    {
        return _distance;
    }

    protected override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

    protected override double CalculateSpeed()
    {
        return (_distance / _duration) * 60;
    }
}