using System;

public class Swimming : Activity
{   
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _activity = "Swimming";
        _laps = laps;
    }

    protected override double CalculateDistance()
    {
        return (_laps * 50) / 1000D;
    }

    protected override double CalculatePace()
    {
        return _duration / CalculateDistance();
    }

    protected override double CalculateSpeed()
    {
        return 60 / CalculatePace();
    }
}