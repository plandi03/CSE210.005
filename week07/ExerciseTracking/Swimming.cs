using System;

public class Swimming : Activity
{
    private int _laps; // Number of laps

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Distance in miles (50 meters per lap)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // Pace in min per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}