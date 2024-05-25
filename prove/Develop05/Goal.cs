public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public int Points => _points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, -points)
    {
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true; 
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Negative Points: {_points})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}: Negative {_points} points";
    }
}
