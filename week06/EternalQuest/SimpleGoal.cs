using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }

    public override string GetStringRepresentation()
    {
        return _isComplete ? "[X] " + _shortName : "[ ] " + _shortName;
    }
}
