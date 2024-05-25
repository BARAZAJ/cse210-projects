public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never marked complete, but we can log progress or points
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never truly complete
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}: {_points} points";
    }
}
