using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance(); // Abstract method for distance
    public abstract double GetSpeed();    // Abstract method for speed
    public abstract double GetPace();     // Abstract method for pace

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} ({Minutes} min)";
    }
}