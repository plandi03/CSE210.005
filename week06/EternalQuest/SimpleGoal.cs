using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points; // Return the points for this goal
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Rename the property to avoid conflict
    public bool CompletionStatus
    {
        get { return _isComplete; }
        set { _isComplete = value; }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName} ({_description})";
    }
}