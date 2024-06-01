using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _activity = "Cycling";
        _speed = speed;
    }

    protected override double CalculateDistance()
    {
        return _speed * (_duration / 60D);
    }

    protected override double CalculatePace()
    {
        return 60 / _speed;
    }

    protected override double CalculateSpeed()
    {
        return _speed;
    }
}