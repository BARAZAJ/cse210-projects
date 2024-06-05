public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
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
        return $"{_shortName}: {_description} (Points: {_points})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}: {_points} points";
    }

    public override string GetCheckboxStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }
}
